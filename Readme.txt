- ขั้นตอนการตั้งค่าสำหรับรัน proxy ในเครื่องเดียวกับโปรแกรม claymore
1. เพิ่ม host eth.fake.com ที่ไฟล์ hosts ใน c:\windows\system32\drivers\etc\
   ตัวอย่าง publicip คือ 123.123.140.1 ดังนั้นให้ใส่ 123.123.140.1 eth.fake.com ที่บรรทัดสุดท้ายของไฟล์  hosts
2. ทำการ forward port ที่ router โดยเข้าที่หน้าเว็บของ router แล้ว forward port 9999 (หรือใช้ port อื่นก็ได้) ของ proxy ที่คุณกำหนดไว้ให้ชี้มาที่ IP เครื่องที่รันโปรแกรม Proxy DevFee

- หากรันโปรแกรม proxy คนละเครืองกับโปรแกรม claymore กำหนดแค่ hosts file ดังตัวอย่างนี้
1. เพิ่ม host eth.fake.com ที่ไฟล์ hosts ใน c:\windows\system32\drivers\etc\
   ตัวอย่าง ip เครื่องที่รันโปรแกรม proxydevfee คือ 192.168.1.39 ดังนั้นให้ใส่ 192.168.1.39 eth.fake.com ที่บรรทัดสุดท้ายของไฟล์  hosts

- หลังจาก forward port และกำหนด host file เสร็จแล้วให้เปลี่ยน bat file ที่รัน EthDcrMiner64.exe เปลี่ยน pool เป็น eth.fake.com:9999 (port ขึ้นอยู่กับที่ใช้ forward port ใน router นะครับ)

System Requirement
.Net 4.0
    