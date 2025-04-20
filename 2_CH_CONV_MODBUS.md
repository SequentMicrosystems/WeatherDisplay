# Two Channel Converter Modbus Registers description

## Modbus object types
All modbus RTU object type with standard addresses are implemented : Coils, Discrete Inputs, Input registers, Holding registers.

### Coils

Acces level Read/Write, Size 1 bit

| Device function | Modbus Address | Description |
| --- | --- | --- |
| COIL_START_CALIB_CMD | 0x01| Write 1 to start calibration with the last values from the calibration registers|
| COIL_VIN_5V| 0x02 | Set the input range for voltage channel 1 - 0..5V; 0 - 0..100mV|



### Discrete Inputs

Access level Read Only, Size 1 bit

| Device function | Register Address | Modbus Address | Description | 
| --- | --- | --- | --- |
| DI_CALIB_PROGRESS | 0x01 | 10001 | Calibration in progress flag |
| DI_CALIB_DONE | 0x01 | 10002 | Calibration done flag |
| DI_CALIB_ERROR | 0x01 | 10003 | Calibration error flag |



### Input registers

Access level Read Only, Size 16 bits

| Device function | Register Address | Description | Measurement Unit |
| --- | --- | --- | --- |
| IR_V_IN_HI | 30001 | Voltage Input high word of float |  |
| IR_V_IN_LO | 30002 | Voltage Input low word of float |  |
| IR_RTD_HI | 30003 | RTD themperature high word of float | C |
| IR_RTD_LO | 30004 | RTD themperature low word of float | C |
| IR_4_20MA_OUT_FB_HI | 30005 |4-20mA out feedback high word of float |  |
| IR_4_20MA_OUT_FB_LO | 30006 |4-20mA out feedback low word of float |  |


### Holding registers

Access level Read/Write, Size 16 bits

| Device function | Register Address | Modbus Address | Measurement Unit | Range | Comment |
| --- | --- | --- | --- | --- | --- |
| HR_CALIB_VALUE_HI | 40001 | 0x00 |  |  | Calibration value as a floating point number |
| HR_CALIB_VALUE_LO | 40002 | 0x01 |  |  | Calibration value as a floating point number |
| HR_CALIB_CH | 40003 | 0x02 |  |  | Calibration works only from command line |
| HR_BAUDRATE | 40004 | 0x03 | hz/100 | 12..9216 | |
| HR_ADDRESS | 40005 | 0x04 | | 1..254 | |
| HR_LOW_TEMP | 40006 | 0x05 | degC/100| -32000..32000| The temperature corespond to 4mA output |
| HR_HIGH_TEMP | 40007 | 0x06 | degC/100| -32000..32000| The temperature corespond to 20mA output |

## Function codes implemented

* Read Coils (0x01)
* Read Discrete Inputs (0x02)
* Read Holding Registers (0x03)
* Read Input Registers (0x04)
* Write Single Coil (0x05)
* Write Single Register (0x06)
* Write Multiple Coils (0x0f)
* Write Multiple registers (0x10)
