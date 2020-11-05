#include <LiquidCrystal.h>
#include "DHT.h"
#define TERM 9
#define DHTTYPE DHT11
DHT termometr(TERM, DHTTYPE);
int count = 0;
float tempo = 0;
float tempo1 = 0;
const int maks = 15;
int umidita = 45 ;
int temperatura = 21;
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
int button = 8;
int switch1 = 0;
int switch2 = 6;
int switch3 = 10;
int switch4 = 13;
void setup() {
  // put your setup code here, to run once:
  pinMode(switch1, OUTPUT);
  pinMode(switch2, OUTPUT);
  pinMode(switch3, OUTPUT);
  pinMode(switch4, OUTPUT);
  termometr.begin();
  lcd.begin(16, 2);
  pinMode(button, INPUT);
}

void loop() {

  float temp = termometr.readTemperature();
  float hum = termometr.readHumidity();
  if (hum < umidita)
  {
    digitalWrite(switch1, HIGH);
  }
  else digitalWrite(switch1, LOW);
  if (temp < temperatura - 3)
  {
    digitalWrite(switch2, HIGH);
  }
  else digitalWrite(switch2, LOW);
  if (temp > temperatura + 3)
  {
    digitalWrite(switch3, HIGH);
  }
  else digitalWrite(switch3, LOW);
  if (tempo > 2400) //300 to 3 min
  {
    digitalWrite(switch4, HIGH);
    //delay(7000);
   tempo=2500;
   tempo1+=0.6;
  }
 
   if(tempo1>600){
    digitalWrite(switch4, LOW);
    tempo=0;
    tempo1=0;
   }
  
  if (digitalRead(button) == 1)
  {
    count = count + 1;
  }

  // put your main code here, to run repeatedly:
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("TEMP: ");
  lcd.print(temp);
 if (digitalRead(switch3) == 1) 
 {
    lcd.print(" RAF");
 }
 else if (digitalRead(switch2) == 1) 
 {
    lcd.print(" RIS");
 }
  lcd.setCursor(0, 1);
  lcd.print("UMID: ");
  lcd.print(hum);
 if (digitalRead(switch1) == 1) 
 {
  lcd.print(" ON");
 }
  if (count > 5)
  {
    count = 1;
  }
  switch (count) {
    case 1:
      plusHum();
      break;
    case 2:
      minusHum();
      break;
    case 3:
      plusTemp();
      break;
    case 4:
      minusTemp();
      break;

  }
  tempo = tempo + 0.6;
  delay(500);

}
void plusHum()
{
  umidita = umidita + 1;
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("HUM + : ");
  lcd.print(umidita);
  lcd.print("%");
  delay(1000);
  

}
void minusHum()
{
  umidita = umidita - 1;
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("HUM - : ");
  lcd.print(umidita);
  lcd.print("%");
  delay(1000);
}
void plusTemp()
{
  temperatura = temperatura + 1;
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("TEMP + : ");
  lcd.print(temperatura);
  delay(1000);
}
void minusTemp()
{
  temperatura = temperatura - 1;
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("TEMP - : ");
  lcd.print(temperatura);
  delay(1000);
}
