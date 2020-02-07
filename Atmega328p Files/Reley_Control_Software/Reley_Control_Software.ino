void setup() {
  
Serial.begin(9600);
Serial.println("Connection successfull.");
delay(100);

pinMode(12,OUTPUT);
pinMode(11,OUTPUT);
pinMode(10,OUTPUT);
pinMode(9,OUTPUT);
pinMode(8,OUTPUT);
pinMode(7,OUTPUT);
pinMode(6,OUTPUT);
pinMode(5,OUTPUT);
pinMode(4,OUTPUT);
pinMode(3,OUTPUT);
pinMode(2,OUTPUT);

}

void loop() {

if (Serial.available())
  {
int state1 = Serial.parseInt();
//--------------------------------------------------
//--------------------------------------------------
if (state1 == 3)
{
digitalWrite(12, HIGH);
Serial.println("Relay 11 is ON");
delay(100);
}
if(state1 == 4)
{
digitalWrite(12, LOW);
Serial.println("Relay 11 is OFF");
delay(100);
}
//--------------------------------------------------
if (state1 == 5)
{
digitalWrite(11, HIGH);
Serial.println("Relay 10 is ON");
delay(100);
}
if(state1 == 6)
{
digitalWrite(11, LOW);
Serial.println("Relay 10 is OFF");
delay(100);
}
//--------------------------------------------------
if (state1 == 7)
{
digitalWrite(10, HIGH);
Serial.println("Relay 9 is ON");
delay(100);
}
if (state1 == 8)
{
digitalWrite(10, LOW);
Serial.println("Relay 9 is OFF");
delay(100);
}
//--------------------------------------------------
if (state1 == 9)
{
digitalWrite(9, HIGH);
Serial.println("Relay 8 is ON");
delay(100);
}
if (state1 == 10)
{
digitalWrite(9, LOW);
Serial.println("Relay 8 is OFF");
delay(100);
}
//--------------------------------------------------
if (state1 == 11)
{
digitalWrite(8, HIGH);
Serial.println("Relay 7 is ON");
delay(100);
}
if (state1 == 12)
{
digitalWrite(8, LOW);
Serial.println("Relay 7 is OFF");
delay(100);
}
//--------------------------------------------------
if (state1 == 13)
{
digitalWrite(7, HIGH);
Serial.println("Relay 6 is ON");
delay(100);
}
if (state1 == 14)
{
digitalWrite(7, LOW);
Serial.println("Relay 6 is OFF");
delay(100);
}
//--------------------------------------------------
if (state1 == 15)
{
digitalWrite(6, HIGH);
Serial.println("Relay 5 is ON");
delay(100);
}
if (state1 == 16)
{
digitalWrite(6, LOW);
Serial.println("Relay 5 is OFF");
delay(100);
}
//--------------------------------------------------
if (state1 == 17)
{
digitalWrite(5, HIGH);
Serial.println("Relay 4 is ON");
delay(100);
}
if (state1 == 18)
{
digitalWrite(5, LOW);
Serial.println("Relay 4 is OFF");
delay(100);
}
//--------------------------------------------------
if (state1 == 19)
{
digitalWrite(4, HIGH);
Serial.println("Relay 3 is ON");
delay(100);
}
if (state1 == 20)
{
digitalWrite(4, LOW);
Serial.println("Relay 3 is OFF");
delay(100);
}
//--------------------------------------------------
if (state1 == 21)
{
digitalWrite(3, HIGH);
Serial.println("Relay 2 is ON");
delay(100);
}
if (state1 == 22)
{
digitalWrite(3, LOW);
Serial.println("Relay 2 is OFF");
delay(100);
}
//--------------------------------------------------
if (state1 == 23)
{
digitalWrite(2, HIGH);
Serial.println("Relay 1 is ON");
delay(100);
}
if (state1 == 24)
{
digitalWrite(2, LOW);
Serial.println("Relay 1 is OFF");
delay(100);
}
//--------------------------------------------------
  }
}
