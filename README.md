1. Conexiones del hardware
Sensor RFID (RC522)
VCC → 5V (Arduino)
GND → GND (Arduino)
SDA → Pin 10 (Arduino)
SCL → Pin 13 (Arduino)
MOSI → Pin 11 (Arduino)
MISO → Pin 12 (Arduino)
RST → Pin 9 (Arduino)
Pantalla LCD con módulo I2C
VCC → 5V (Arduino)
GND → GND (Arduino)
SDA → Pin A4 (Arduino)
SCL → Pin A5 (Arduino)
2. Librerías necesarias
Para que el código funcione correctamente, necesitas instalar las siguientes librerías en el Arduino IDE:

MFRC522: Para trabajar con el lector RFID (RC522).

Puedes instalarla desde el Administrador de Librerías de Arduino:
Sketch > Incluir Librería > Administrar Librerías y buscar MFRC522.
Wire: Esta librería es necesaria para la comunicación I2C (viene preinstalada en Arduino IDE).

LiquidCrystal_I2C: Para controlar la pantalla LCD con el módulo I2C.

También puedes instalarla desde el Administrador de Librerías de Arduino:
Sketch > Incluir Librería > Administrar Librerías y buscar LiquidCrystal I2C.
3. Descripción del funcionamiento
Este sistema tiene como objetivo registrar la asistencia de empleados o usuarios mediante el uso de un sensor RFID y mostrar la información en una pantalla LCD.

Funcionamiento del sistema:
Lectura de la tarjeta RFID: Cuando un empleado acerca su tarjeta RFID al lector, el sensor RC522 lee la señal y obtiene un ID único de la tarjeta.
Identificación del usuario: El sistema identifica al usuario basado en el ID de la tarjeta almacenado en una base de datos o lista preconfigurada dentro del código.
Marcación de asistencia: Si el ID del usuario es reconocido, el sistema marca la hora de entrada o hora de salida dependiendo de si es la primera vez que se escanea la tarjeta o si ya se ha registrado anteriormente.
Pantalla LCD: La pantalla LCD muestra la información sobre el usuario y el estado de la asistencia (si es entrada o salida), así como la hora en formato adecuado.
Flujo general:
Entrada: Cuando se detecta una tarjeta, si es la primera vez que se escanea, registra la hora de entrada.
Salida: Si el mismo usuario escanea su tarjeta nuevamente, el sistema registra la hora de salida.
Visualización: En la pantalla LCD se muestra el nombre del empleado (si está asociado con el ID) y la hora de entrada o salida.
