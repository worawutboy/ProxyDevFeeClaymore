using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace ProxyDevFeeClaymore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmProxy());
        }
    }
    public class ListJson
    {
        public string site { get; set; }
        public string url { get; set; }
        public string r { get; set; }
    }
    public class TcpForwarderSlim
    {
        internal static log4net.ILog Log { get; set; }
        public delegate void ConsoleEventMsg(string message);
        public event ConsoleEventMsg writelog;
        public event ConsoleEventMsg writelog2;

        static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly Socket _mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<TcpForwarderSlim> destinations = new List<TcpForwarderSlim>();
        static string walletaddress;
        string console = "";
        private bool IsRuning;
        public void Stop()
        {
            try
            {
                IsRuning = false;
                _mainSocket.Close();
                foreach (var item in destinations)
                {
                    //item.
                    item._mainSocket.Close();
                }
            }
            catch { }
        }
        public TcpForwarderSlim()
        {
        }
        public void Start(IPEndPoint local, IPEndPoint remote, string _walletaddress,ref string _console)
        {
            IsRuning = true;
            _mainSocket.Bind(local);
            _mainSocket.Listen(500);

            walletaddress = _walletaddress;
            console = _console;
            new Thread(() =>
            {
                try
                {
                    while (IsRuning)
                    {
                        var source = _mainSocket.Accept();                       
                        var destination = new TcpForwarderSlim();

                        destinations.Add(destination);
                        var state = new State(source, destination._mainSocket);
                        destination.Connect(remote, source, writelog);
                        source.BeginReceive(state.Buffer, 0, state.Buffer.Length, 0, OnDataReceive, state);
                    }
                }
                catch { }
            }).Start();
        }



        private void Connect(EndPoint remoteEndpoint, Socket destination, ConsoleEventMsg _writelog)
        {
            try
            {
                writelog = _writelog;
                var state = new State(_mainSocket, destination);
                _mainSocket.Connect(remoteEndpoint);
                Console.WriteLine("{0} Client Connect :{1}", DateTime.Now, state.DestinationSocket.RemoteEndPoint);              
                if (writelog != null)
                {
                    writelog(String.Format("{0} Client Connect :{1}", DateTime.Now, state.DestinationSocket.RemoteEndPoint));
                }
                logger.Info(String.Format("Client Connect :{0}", state.DestinationSocket.RemoteEndPoint));
                _mainSocket.BeginReceive(state.Buffer, 0, state.Buffer.Length, SocketFlags.None, OnDataReceive, state);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connect Error : {0}", ex.Message);
                logger.Error(ex.Message);
            }

        }

        private  void OnDataReceive(IAsyncResult result)
        {
            var state = (State)result.AsyncState;
            try
            {


                var bytesRead = state.SourceSocket.EndReceive(result);
                var resultxt = System.Text.Encoding.UTF8.GetString(state.Buffer, 0, bytesRead);
                byte[] bSend = state.Buffer;
                int lengSend = bytesRead;
                // Console.WriteLine(resultxt);
                if (resultxt.ToLower().Contains("worker") && resultxt.ToLower().Contains("eth_submitlogin") && !resultxt.ToLower().Contains(walletaddress))
                {
                    logger.Info("Fond DevFee :" + resultxt);
                    string devfeewallet = resultxt.Substring(resultxt.IndexOf("0x"), walletaddress.Length);
                    resultxt = resultxt.Replace(devfeewallet, walletaddress);                  
                    bSend = Encoding.ASCII.GetBytes(resultxt);
                    lengSend = bSend.Length;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(String.Format("{0} Fond DevFee ", DateTime.Now));
                    console = String.Format("{0}: [Fond DevFee] you can donate DevFee at {1}", DateTime.Now,devfeewallet);
                    if (writelog != null)
                    {
                        writelog(console);
                    }
                    Console.WriteLine(resultxt);
                    // bytesRead = state.Buffer.Length;
                    Console.ForegroundColor = ConsoleColor.White;
                    logger.Info("chang to :" + resultxt);

                }
                else if (resultxt.ToLower().Contains("eth_submitlogin"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(String.Format("{0} Login \n {1} ", DateTime.Now, resultxt.Trim()));
                    Console.ForegroundColor = ConsoleColor.White;
                }               
                if (state.SourceSocket.Connected)
                {

                    state.DestinationSocket.Send(bSend, lengSend, SocketFlags.None);
                    state.SourceSocket.BeginReceive(state.Buffer, 0, bytesRead, 0, OnDataReceive, state);
                }
                else
                {
                    state.DestinationSocket.Close();
                    state.SourceSocket.Close();
                    logger.Info("Close socket");
                }


            }
            catch (Exception ex)
            {
                state.DestinationSocket.Close();
                state.SourceSocket.Close();
                logger.Error(ex.Message);
                logger.Info("Close socket");
            }
        }
        private class Myworker
        {
            public string worker { get; set; }
            public string jsonrpc { get; set; }
            public string method { get; set; }
            public int id { get; set; }

        }

        private class State
        {
            public Socket SourceSocket { get; private set; }
            public Socket DestinationSocket { get; private set; }
            public byte[] Buffer { get; set; }

            public State(Socket source, Socket destination)
            {
                SourceSocket = source;
                DestinationSocket = destination;
                Buffer = new byte[8019];
            }
        }
    }


}
