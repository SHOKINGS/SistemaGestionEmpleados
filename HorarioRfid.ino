#include <SPI.h>
#include <MFRC522.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <RTClib.h>

#define SS_PIN 10
#define RST_PIN 9

MFRC522 rfid(SS_PIN, RST_PIN); 
LiquidCrystal_I2C lcd(0x27, 16, 2); 
RTC_DS3231 rtc; 

String lastUID = "";
bool isCheckedIn = false; 
DateTime checkInTime, checkOutTime; 

void setup() {
  SPI.begin(); 
  rfid.PCD_Init(); 
  lcd.init(); 
  lcd.backlight(); 
  rtc.begin(); 
}

void loop() {
  if (!rfid.PICC_IsNewCardPresent() || !rfid.PICC_ReadCardSerial()) return;

  String uid = "";
  for (byte i = 0; i < rfid.uid.size; i++) {
    uid += String(rfid.uid.uidByte[i], HEX);
  }
  uid.toUpperCase();

  if (uid != lastUID) {
    lastUID = uid;
    if (!isCheckedIn) {
      checkInTime = rtc.now();
      isCheckedIn = true;
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("ID: " + uid);
      lcd.setCursor(0, 1);
      lcd.print("Entrada: ");
      lcd.print(checkInTime.timestamp(DateTime::TIMESTAMP_TIME));
    } else {
      checkOutTime = rtc.now();
      isCheckedIn = false;
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("ID: " + uid);
      lcd.setCursor(0, 1);
      lcd.print("Salida: ");
      lcd.print(checkOutTime.timestamp(DateTime::TIMESTAMP_TIME));
    }
  }
  delay(1000);
  rfid.PICC_HaltA();
}
