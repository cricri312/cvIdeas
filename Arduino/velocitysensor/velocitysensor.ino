int analogPin = A0; //Analog in for value of sensor
int tim;
int timPom=0;
float velo=0; //velocity
float calculateSpeed(float t) //calculate speed in m/s for a 1cm
{
  float x=t;
  float t1=x/1000;
  velo=0.01/t1;  //0.01 is a 1cm but converted to a m, so 1 cm=0.01 m 
 return velo;
}
int msTokmh(float velocity){ //convert the m/s to a normal speed km/h in a int.
  return velocity*3.6;
  }
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  int swiatlo = analogRead(analogPin);
  if(swiatlo<465){tim++; timPom=tim;} //465 is a value to modify, you must set your const value from sensor. exemple, the const value may be 500 but in my case is 465.
  else if(swiatlo>465){tim=0;}
  Serial.println(calculateSpeed(timPom));
  Serial.println(msTokmh(calculateSpeed(timPom)));
  
}
