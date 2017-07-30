ขั้นตอนการตั้งค่าสำหรับรัน proxy ในเครื่องเดียวกับโปรแกรม claymore
1. เพิ่ม host eth.fake.com ที่ไฟล์ hosts ใน c:\windows\system32\drivers\etc\
   ตัวอย่าง publicip คือ 123.123.140.1 ดังนั้นให้ใส่ 123.123.140.1 eth.fake.com ที่บรรทัดสุดท้ายของไฟล์  hosts
2. ทำการ forward port ที่ router โดยเข้าที่หน้าเว็บของ router แล้ว forward port ของ proxy ที่คุณกำหนดไว้ให้ชี้มาที่ IP เครื่องที่รันโปรแกรม Proxy DevFee
    