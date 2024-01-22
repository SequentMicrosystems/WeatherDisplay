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

| Device function | Register Address | Modbus Address | Description | 
| --- | --- | --- | --- |
| DI_CALIB_PROGRESS | 0x01 | 10001 | Calibration in progress flag |
| DI_CALIB_DONE | 0x01 | 10002 | Calibration done flag |
| DI_CALIB_ERROR | 0x01 | 10003 | Calibration error flag |
| DI_EXT_SNS_ERROR | 0x01 | 10004 | External pressure sensor (BME280) error flag |
| DI_INT_SNS_ERROR | 0x01 | 10005 | Internal pressure sensor error flag |
| DI_ACC_ERROR | 0x01 | 10006 | Acceleration sensor error flag |


### Input registers

Access level Read Only, Size 16 bits

| Device function | Register Address | Description | Measurement Unit |
| --- | --- | --- | --- |
| IR_4_20MA_IN_HI1 | 30001 | 4-20mA Input 1 high word of float |  |
| IR_4_20MA_IN_LO1 | 30002 | 4-20mA Input 1 low word of float |  |
| IR_4_20MA_IN_HI2 | 30003 | 4-20mA Input 2 high word of float |  |
| IR_4_20MA_IN_LO2 | 30004 | 4-20mA Input 2 low word of float |  |
| IR_0_5V_IN_HI | 30005 |0-5V Input high word |  |
| IR_0_5V_IN_LO | 30006 |0-5V Input low word |  |
| IR_RTD_HI | 30007 | Temperature of PT1000 RTD sensor high word  |&deg;C |
| IR_RTD_HI | 30008 | Temperature of PT1000 RTD sensor low word  |&deg;C |
| IR_PULSE_COUNTER| 30009 | Counter for digital inpiut |  |
| IR_PHOTO_HI | 30010 | Photo sensor high word |  |
| IR_PHOTO_LO | 30011 | Photo sensor low word |  |
| IR_INT_PRESS_HI| 30012 |Internal pressure sensor high word of float | Pa |
| IR_INT_PRESS_LO | 30013 | Internal pressure sensor low word of float | Pa |
| IR_INT_TEMP_HI | 30014 | Internal temperature sensor high word | &deg;C |
| IR_INT_TEMP_LO | 30015 | Internal temperature sensor low word | &deg;C |
| IR_PITCH_HI | 30016 | Inclination angle, pitch high word| &deg; |
| IR_PITCH_LO | 30017 | Inclination angle, pitch low word| &deg; |
| IR_ROLL_HI | 30018 | Inclination angle, roll high word | &deg; |
| IR_ROLL_LO | 30019 | Inclination angle, roll low word | &deg; |
| IR_EXT_PRESS_HI | 30020 | Ext BME280 pressure high word of float | Pa |
| IR_EXT_PRESS_LO | 30021 | Ext BME280 pressure low word of float | Pa |
| IR_EXT_TEMP_HI | 30022 | Ext BME280 temperature high word | &deg;C |
| IR_EXT_TEMP_LO | 30023 | Ext BME280 temperature low word | &deg;C |
| IR_EXT_HUM_HI | 30024 | Ext BME280 humidity high word | % |
| IR_EXT_HUM_LO | 30025 | Ext BME280 humidity low word | % |



### Holding registers

Access level Read/Write, Size 16 bits

| Device function | Register Address | Modbus Address | Measurement Unit | Range | Comment |
| --- | --- | --- | --- | --- | --- |
| HR_CALIB_VALUE_HI | 40001 | 0x00 |  |  | Calibration value as a floating point number |
| HR_CALIB_VALUE_LO | 40002 | 0x01 |  |  | Calibration value as a floating point number |
| HR_CALIB_CH | 40002 | 0x02 |  |  | Calibration works only from command line |
| HR_BAUDRATE | 40003 | 0x03 | hz/100 | 12..9216 | |
| HR_ADDRESS | 40004 | 0x04 | | 1..254 | |



## Function codes implemented

* Read Coils (0x01)
* Read Discrete Inputs (0x02)
* Read Holding Registers (0x03)
* Read Input Registers (0x04)
* Write Single Coil (0x05)
* Write Single Register (0x06)
* Write Multiple Coils (0x0f)
* Write Multiple registers (0x10)

*Notes: The calibration can be done and monitored only from CLI, so the variables calibration related are not implemented*

