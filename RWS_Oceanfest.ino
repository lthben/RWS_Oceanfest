#include <Button.h>

Button button1(5); // dolphin
Button button2(6); // herring
Button button3(7); // whale

void setup() {
  button1.begin();
  button2.begin();
  button3.begin();

  while (!Serial) { }; // for Leos
  Serial.begin(9600);
}

void loop() {
  if (button1.pressed())
    Serial.println("d");

  if (button2.pressed())
    Serial.println("h");

  if (button3.pressed())
    Serial.println("w");
}
