
# Project Backend Instructions

## ใช้ controller, service pattern
- แยก logic ของการจัดการข้อมูลออกเป็น service
- controller จะรับ request และส่ง response โดยเรียกใช้ service ในการจัดการข้อมูล

## ใช้ sql server เป็นฐานข้อมูลหลัก
- ตั้งค่าการเชื่อมต่อฐานข้อมูลในไฟล์ configuration
- ใช้ ORM หรือ query builder ที่รองรับ sql server

## ไม่สร้าง interface
- ถ้าproject มีการเขียน interface สำหรับ service อยู่แล้ว ให้ลบแก้ไข


## Output Rules (Strict)

### Required
- แก้ไขหรือสร้างได้เฉพาะไฟล์ที่ผู้ใช้ระบุเท่านั้น
- หากผู้ใช้ไม่ได้ระบุไฟล์ ห้ามสร้างไฟล์ใหม่ทุกชนิด
- หากจำเป็นต้องอธิบาย ให้ใช้ comment สั้น ๆ ในไฟล์เดิมเท่านั้น

### Forbidden
- ห้ามสร้างไฟล์ใหม่ทุกชนิด (รวมถึง `.md`)
- ห้ามสร้างเอกสารประกอบ เช่น README, docs, notes
- ห้ามอธิบายนอกไฟล์โค้ด

## File Modification Rules

- อนุญาตให้แก้ไขเฉพาะไฟล์:
    - `.vue`
    - `.ts`
    - `.js`
    - `.css`
- นอกเหนือจากนี้ถือว่า forbidden

## Absolute Rules
- หาก rule ใดขัดแย้งกัน ให้ยึด Output Rules เป็นหลัก

---

## Project Frontend เป็น vue 3 + typescript

---
## ห้ามแก้ไขไฟล์ ที่อยุ่ในโฟรเดอร์ ดังนี้
- `Models/Bms/Entities`
- `Models/Bms/Stored`