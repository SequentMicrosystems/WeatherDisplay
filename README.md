# WeatherDisplay
Data display application for Weather Station
The weather station controller implements a Modbus RTU Slave protocol over RS485 port. The config parameters for the port are available on the CLI port.
## Modbus object types
All modbus RTU object type with standard addresses are implemented : Coils, Discrete Inputs, Input registers, Holding registers.

### Coils

Acces level Read/Write, Size 1 bit

| Device function | Register Address | Modbus Address |
| --- | --- | --- |


### Discrete Inputs

Access level Read Only, Size 1 bit

| Device function | Register Address | Modbus Address |
| --- | --- | --- |



### Input registers

Access level Read Only, Size 16 bits

| Device function | Register Address | Description | Measurement Unit |
| --- | --- | --- | --- |
| IR_4_20MA_IN1 | 30001 | 4-20mA Input 1 | uA |
| IR_4_20MA_IN2 | 30002 | 4-20 Input 2 | uA |
| IR_0_5V_IN | 30003 |0-5V Input | mV |
| IR_RTD | 30004 | Temperature of PT1000 RTD sensor | 0.01C |
| IR_PULSE_COUNTER| 30005 | Counter for digital inpiut |  |
| IR_PHOTO | 30006 | Voltage of photo sensor | mV |
| IR_INT_PRESS_HI| 30007 |Internal pressure sensor high word of float | Pa |
| IR_INT_PRESS_LO | 30008 | Internal pressure sensor low word of float | Pa |
| IR_INT_TEMP | 30009 | Internal temperature sensor |  0.01C |
| IR_PITCH | 30010 | Inclination angle, pitch | 0.01deg |
| IR_ROLL | 30011 | Inclination angle, roll | 0.01deg |
| IR_EXT_PRESS_HI | 30012 | Ext BME280 pressure high word of float | Pa |
| IR_EXT_PRESS_LO | 30013 | Ext BME280 pressure low word of float | Pa |
| IR_EXT_TEMP | 30014 | Ext BME280 temperature | 0.01C |
| IR_EXT_HUM | 30015 | Ext BME280 humidity | 0.01% |



### Holding registers

Access level Read/Write, Size 16 bits

| Device function | Register Address | Modbus Address | Measurement Unit | Range | Comment |
| --- | --- | --- | --- | --- | --- |
| HR_CALIB_VALUE | 40001 | 0x00 |  |  | Calibration works only from command line |
| HR_CALIB_CH | 40002 | 0x01 |  |  | Calibration works only from command line |
| HR_BAUDRATE | 40003 | 0x02 | hz/100 | 12..9216 | |
| HR_ADDRESS | 40004 | 0x03 | | 1..254 | |



## Function codes implemented

* Read Coils (0x01)
* Read Discrete Inputs (0x02)
* Read Holding Registers (0x03)
* Read Input Registers (0x04)
* Write Single Coil (0x05)
* Write Single Register (0x06)
* Write Multiple Coils (0x0f)
* Write Multiple registers (0x10)
