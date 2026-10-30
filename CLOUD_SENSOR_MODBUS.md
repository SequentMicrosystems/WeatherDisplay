# Cloud Sensor Modbus Register Map

Modbus settings: 9600 baud, 8N1, no parity. Default device address: 0x01 (user-configurable through MODBUS 485 port).

## Modbus object types
This implementation supports all Modbus RTU object types with standard addresses: Coils, Discrete Inputs, Input Registers, and Holding Registers.

### Coils

Access level: Read/Write, Size: 1 bit

| Device function | Register Address | Modbus Address | Description |
| --- | --- | --- | --- |
| COIL_4_20_MODE | 0001 | 0x00 | 0 = Cloud Fraction % (default). 1 = Oktas |
| COIL_HUM_HEAT | 0002 | 0x01 | 1 - turn on humidity sensor autoheat (remove condensation), turn back to 0 when done (not yet implemented)|


### Discrete Inputs

Access level Read Only, Size 1 bit

| Device function | Register Address | Modbus Address | Description |
| --- | --- | --- | --- |
| DI_MODE_FLAG | 10001 | 0x00 | 0 = DAY mode, 1 = NIGHT mode|
| DI_CALIBRATION_STATUS | 10002 | 0x01 | Not implemented |
| DI_HUMIDITY_OK | 10003 | 0x02 | 0  = initialization or error, 1 = OK |
| DI_MLX_OK | 10004 | 0x03 | 0  = initialization or error, 1 = OK |
| DI_IRADIANCE_OK | 10005 | 0x04 | 0  = initialization or error, 1 = OK |
| DI_GPS_FIX_OK | 10006 | 0x05 | 0  = Not FIX, 1 = OK |

### Input registers

Access level Read Only, Size 16 bits

| Device function | Register Address | Modbus Address| Description | Measurement Unit / resolution |
| --- | --- | --- | --- | --- |
| IR_CLOUD_FRACTION| 30001 | 0x00 |Cloud Fraction avg| 0.01% |
| IR_OKTAS| 30002 | 0x01 | Cloud cover in oktas. 0 = clear, 8 = fully overcast|  |
| IR_SKY_TEMP | 30003 | 0x02 | T_sky from MLX90614 (e.g. −250 = −25.0 °C) | 0.1°C |
| IR_AMBIENT_TEMP | 30004 | 0x03 | T_amb from SHT31 | 0.1°C  |
| IR_HUMIDITY | 30005 | 0x04 | Relative Humidity | 0.1 % |
| IR_IRRADIANCE | 30006 | 0x05 | Irradiance converted from lux | W/m² |
| IR_CLEARNESS_IDX | 30007 | 0x06 | Clearness Index kt × 1000 |  |
| IR_DELTA_T | 30008 | 0x07 | T_amb − T_sky | 0.1°C |
| IR_SOLAR_ELEVATION | 30009 | 0x08 |	Solar Elevation | 0.1° |
| IR_RAW_CF | 30010 | 0x09 | Unfiltered CF × 100 |  0.01%  |
| IR_HARTBEAT | 30011 | 0x0A | Heartbeat Counter | s |
| IR_GPS_LAT | 30012 | 0x0B | GPS Latitude | 0.01° |
| IR_GPS_LON | 30013 | 0x0C | GPS Longitude | 0.01° |
| IR_GPS_ALT | 30014 | 0x0D | GPS Altitude | m |
| IR_UPTIME | 30015 | 0x0E | Uptime | s |


### Holding registers

Access level: Read/Write, Size: 16 bits

| Device function | Register Address | Modbus Address | Description | Measurement Unit | Range |
| --- | --- | --- | --- | --- | --- |
| HR_ADDRESS | 40001 | 0x00 | Modbus device address. Default: 1 | - | 1..247 |
| HR_BAUDRATE | 40002 | 0x01 | RS485 Baud Rate / 100 | 100bps | 12..9216 |
| HR_PARITY | 40003 | 0x04 |Parity 0=none, 1 = even, 2 = odd | | 0..2 |
| HR_4_20_MODE | 40004 | 0x05 | 0 = Cloud Fraction % (default). 1 = Okta |  | 0..1 |
| HR_FUSION_W1 | 40005 | 0x06 | w1 × 1000 |  | 0..1000|
| HR_FUSION_W2 | 40006 | 0x07 | w2 × 1000  | | 0..1000|
| HR_AVG_WINDOW | 40007 | 0x08 | Averaging Window for CF | | 1..300|
| HR_CLIMATE_ZONE | 40008 | 0x09 | Climate Zone 0=Tropical, 1=Arid, 2=Temperate, 3=High Altitude | | 0..3|
| HR_DELTA_T_CLEAR_DAY | 40009 | 0x0A | Daytime clear-sky anchor | 0.1°C | -200..800|
| HR_DELTA_T_CLEAR_NIGHT | 40010 | 0x0B | Night clear-sky anchor | 0.1°C | -200..800|
| HR_SITE_LAT | 40011 | 0x0C |Manual lat override if no GPS fix| 0.01° | -9000..9000|
| HR_SITE_LON | 40012 | 0x0D |Manual lat override if no GPS fix|  0.01° | -18000..18000|
| HR_SITE_ALT | 40013 | 0x0E |Manual lat override if no GPS fix| m | -1000..1000|
| HR_LUX_IR_FACTOR | 40014 | 0x0F | Conversion factor | 0.1lux/(W/m2)  | 100..10000|
| HR_FACT_RESET | 40015 | 0x10 | Factory reset (not implemented yet) | | -32767..32767|

## Function codes implemented

* Read Coils (0x01)
* Read Discrete Inputs (0x02)
* Read Holding Registers (0x03)
* Read Input Registers (0x04)
