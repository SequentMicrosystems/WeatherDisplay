# WeatherDisplay
Data display application for Weather Station
The weather station controller implements a Modbus RTU Slave protocol over RS485 port. The config parameters for the port are available on the CLI port.
## Modbus object types
All modbus RTU object type with standard addresses are implemented : Coils, Discrete Inputs, Input registers, Holding registers.

### Coils

Acces level Read/Write, Size 1 bit

| Device function | Modbus Address | Description |
| --- | --- | --- |
| COIL_START_CALIB_CMD | 0x01| Write 1 to start calibration with the last values from the calibration registers|
| COIL_COUNT_RST| 0x02 | Write 1 to reset the  pulse counter|



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
| IR_PULSE_H | 30026 | Pulses per hour for rain sensor| |
| IR_PULSE_24H | 30027 | Pulses per day for rain sensor| |
|IR_0_100MV_IN_HI | 30028 | 0-100mV Input high word |  |
|IR_0_100MV_IN_LO | 30029 | 0-100mV Input low word |  |
|IR_FW_VERSION | 30030 | Firmware version |  |


### Holding registers

Access level Read/Write, Size 16 bits

| Device function | Register Address | Modbus Address | Measurement Unit | Range | Comment |
| --- | --- | --- | --- | --- | --- |
| HR_CALIB_VALUE_HI | 40001 | 0x00 |  |  | Calibration value as a floating point number |
| HR_CALIB_VALUE_LO | 40002 | 0x01 |  |  | Calibration value as a floating point number |
| HR_CALIB_CH | 40003 | 0x02 |  |  | Calibration works only from command line |
| HR_BAUDRATE | 40004 | 0x03 | hz/100 | 12..9216 | |
| HR_ADDRESS | 40005 | 0x04 | | 1..254 | |
| HR_PARITY | 40006 | 0x05| | 0..2| 0=NONE; 1=EVEN; 2=ODD|
|  HR_PARAM_RTD_SLOPE_HI | 40007 | 0x06 | | | RTD slope high word |
| HR_PARAM_RTD_SLOPE_LO | 40008 | 0x07 | | | RTD slope low word |
| HR_PARAM_RTD_INTERCEPT_HI | 40009 | 0x08 | | | RTD intercept high word |
| HR_PARAM_RTD_INTERCEPT_LO | 40010 | 0x09 | | | RTD intercept low word |
| HR_PARAM_VIN_SLOPE_HI | 40011 | 0x0A | | | Voltage input slope high word |
| HR_PARAM_VIN_SLOPE_LO | 40012 | 0x0B | | | Voltage input slope low word |
| HR_PARAM_VIN_INTERCEPT_HI | 40013 | 0x0C | | | Voltage input intercept high word |
| HR_PARAM_VIN_INTERCEPT_LO | 40014 | 0x0D | | | Voltage input intercept low word |
| HR_PARAM_CRT1_SLOPE_HI | 40015 | 0x0E | | | Current 1 slope high word |
| HR_PARAM_CRT1_SLOPE_LO | 40016 | 0x0F | | | Current 1 slope low word |
| HR_PARAM_CRT1_INTERCEPT_HI | 40017 | 0x10 | | | Current 1 intercept high word |
| HR_PARAM_CRT1_INTERCEPT_LO | 40018 | 0x11 | | | Current 1 intercept low word |
| HR_PARAM_CRT2_SLOPE_HI | 40019 | 0x12 | | | Current 2 slope high word |
| HR_PARAM_CRT2_SLOPE_LO | 40020 | 0x13 | | | Current 2 slope low word |
| HR_PARAM_CRT2_INTERCEPT_HI | 40021 | 0x14 | | | Current 2 intercept high word |
| HR_PARAM_CRT2_INTERCEPT_LO | 40022 | 0x15 | | | Current 2 intercept low word |
| HR_PARAM_PHOTO_SLOPE_HI | 40023 | 0x16 | | | Photo sensor slope high word |
| HR_PARAM_PHOTO_SLOPE_LO | 40024 | 0x17 | | | Photo sensor slope low word |
| HR_PARAM_PHOTO_INTERCEPT_HI | 40025 | 0x18 | | | Photo sensor intercept high word |
| HR_PARAM_PHOTO_INTERCEPT_LO | 40026 | 0x19 | | | Photo sensor intercept low word |
| HR_PARAM_BARO_SLOPE_HI | 40027 | 0x1A | | | Barometric pressure slope high word |
| HR_PARAM_BARO_SLOPE_LO | 40028 | 0x1B | | | Barometric pressure slope low word |
| HR_PARAM_BARO_INTERCEPT_HI | 40029 | 0x1C | | | Barometric pressure intercept high word |
| HR_PARAM_BARO_INTERCEPT_LO | 40030 | 0x1D | | | Barometric pressure intercept low word |
| HR_PARAM_ACC_X_1G_HI | 40031 | 0x1E | | | Accelerometer X 1G calibration high word |
| HR_PARAM_ACC_X_1G_LO | 40032 | 0x1F | | | Accelerometer X 1G calibration low word |
| HR_PARAM_ACC_X_OFFSET_HI | 40033 | 0x20 | | | Accelerometer X offset high word |
| HR_PARAM_ACC_X_OFFSET_LO | 40034 | 0x21 | | | Accelerometer X offset low word |
| HR_PARAM_ACC_Y_1G_HI | 40035 | 0x22 | | | Accelerometer Y 1G calibration high word |
| HR_PARAM_ACC_Y_1G_LO | 40036 | 0x23 | | | Accelerometer Y 1G calibration low word |
| HR_PARAM_ACC_Y_OFFSET_HI | 40037 | 0x24 | | | Accelerometer Y offset high word |
| HR_PARAM_ACC_Y_OFFSET_LO | 40038 | 0x25 | | | Accelerometer Y offset low word |
| HR_PARAM_ACC_Z_1G_HI | 40039 | 0x26 | | | Accelerometer Z 1G calibration high word |
| HR_PARAM_ACC_Z_1G_LO | 40040 | 0x27 | | | Accelerometer Z 1G calibration low word |
| HR_PARAM_ACC_Z_OFFSET_HI | 40041 | 0x28 | | | Accelerometer Z offset high word |
| HR_PARAM_ACC_Z_OFFSET_LO | 40042 | 0x29 | | | Accelerometer Z offset low word |
| HR_PARAM_PITCH_OFFSET_HI | 40043 | 0x2A | | | Pitch angle offset high word |
| HR_PARAM_PITCH_OFFSET_LO | 40044 | 0x2B | | | Pitch angle offset low word |
| HR_PARAM_ROLL_OFFSET_HI | 40045 | 0x2C | | | Roll angle offset high word |
| HR_PARAM_ROLL_OFFSET_LO | 40046 | 0x2D | | | Roll angle offset low word |
| HR_PARAM_MODBUS_BAUDRATE_HI | 40047 | 0x2E | | | Modbus baudrate configuration high word |
| HR_PARAM_MODBUS_BAUDRATE_LO | 40048 | 0x2F | | | Modbus baudrate configuration low word |
| HR_PARAM_MODBUS_SETTINGS_HI | 40049 | 0x30 | | | Modbus settings high word |
| HR_PARAM_MODBUS_SETTINGS_LO | 40050 | 0x31 | | | Modbus settings low word |
| HR_PARAM_VIN_RANGE_HI | 40051 | 0x32 | | | Voltage input range high word |
| HR_PARAM_VIN_RANGE_LO | 40052 | 0x33 | | | Voltage input range low word |
| HR_PARAM_MVIN_SLOPE_HI | 40053 | 0x34 | | | Millivolt input slope high word |
| HR_PARAM_MVIN_SLOPE_LO | 40054 | 0x35 | | | Millivolt input slope low word |
| HR_PARAM_MVIN_INTERCEPT_HI | 40055 | 0x36 | | | Millivolt input intercept high word |
| HR_PARAM_MVIN_INTERCEPT_LO | 40056 | 0x37 | | | Millivolt input intercept low word |
| HR_PARAM_RTD_LOW_LIMIT_HI | 40057 | 0x38 | | | RTD low limit high word |
| HR_PARAM_RTD_LOW_LIMIT_LO | 40058 | 0x39 | | | RTD low limit low word |
| HR_PARAM_RTD_HIGH_LIMIT_HI | 40059 | 0x3A | | | RTD high limit high word |
| HR_PARAM_RTD_HIGH_LIMIT_LO | 40060 | 0x3B | | | RTD high limit low word |
| HR_PARAM_VIN_LOW_LIMIT_HI | 40061 | 0x3C | | | Voltage input low limit high word |
| HR_PARAM_VIN_LOW_LIMIT_LO | 40062 | 0x3D | | | Voltage input low limit low word |
| HR_PARAM_VIN_HIGH_LIMIT_HI | 40063 | 0x3E | | | Voltage input high limit high word |
| HR_PARAM_VIN_HIGH_LIMIT_LO | 40064 | 0x3F | | | Voltage input high limit low word |
| HR_PARAM_CRT1_LOW_LIMIT_HI | 40065 | 0x40 | | | Current 1 low limit high word |
| HR_PARAM_CRT1_LOW_LIMIT_LO | 40066 | 0x41 | | | Current 1 low limit low word |
| HR_PARAM_CRT1_HIGH_LIMIT_HI | 40067 | 0x42 | | | Current 1 high limit high word |
| HR_PARAM_CRT1_HIGH_LIMIT_LO | 40068 | 0x43 | | | Current 1 high limit low word |
| HR_PARAM_CRT2_LOW_LIMIT_HI | 40069 | 0x44 | | | Current 2 low limit high word |
| HR_PARAM_CRT2_LOW_LIMIT_LO | 40070 | 0x45 | | | Current 2 low limit low word |
| HR_PARAM_CRT2_HIGH_LIMIT_HI | 40071 | 0x46 | | | Current 2 high limit high word |
| HR_PARAM_CRT2_HIGH_LIMIT_LO | 40072 | 0x47 | | | Current 2 high limit low word |
| HR_PARAM_PHOTO_LOW_LIMIT_HI | 40073 | 0x48 | | | Photo sensor low limit high word |
| HR_PARAM_PHOTO_LOW_LIMIT_LO | 40074 | 0x49 | | | Photo sensor low limit low word |
| HR_PARAM_PHOTO_HIGH_LIMIT_HI | 40075 | 0x4A | | | Photo sensor high limit high word |
| HR_PARAM_PHOTO_HIGH_LIMIT_LO | 40076 | 0x4B | | | Photo sensor high limit low word |
| HR_PARAM_BARO_LOW_LIMIT_HI | 40077 | 0x4C | | | Barometric pressure low limit high word |
| HR_PARAM_BARO_LOW_LIMIT_LO | 40078 | 0x4D | | | Barometric pressure low limit low word |
| HR_PARAM_BARO_HIGH_LIMIT_HI | 40079 | 0x4E | | | Barometric pressure high limit high word |
| HR_PARAM_BARO_HIGH_LIMIT_LO | 40080 | 0x4F | | | Barometric pressure high limit low word |
| HR_PARAM_MVIN_LOW_LIMIT_HI | 40081 | 0x50 | | | Millivolt input low limit high word |
| HR_PARAM_MVIN_LOW_LIMIT_LO | 40082 | 0x51 | | | Millivolt input low limit low word |
| HR_PARAM_MVIN_HIGH_LIMIT_HI | 40083 | 0x52 | | | Millivolt input high limit high word |
| HR_PARAM_MVIN_HIGH_LIMIT_LO | 40084 | 0x53 | | | Millivolt input high limit low word |
| HR_SPARE | 40085 | 0x54 | | | Spare register |



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

