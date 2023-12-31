# Command Line Interface
The weather station card contains a debug port, which phisical layer is asyncronus USART, TTL levels and implements CLI.

## Hardware connection
User needs an USB to USART (TTL) adaptor and a PC with USB port.
The adaptor could be any found on the market, for example [this one](https://www.amazon.com/HiLetgo-CP2102-Converter-Adapter-Downloader/dp/B00LODGRV8/ref=sr_1_1_sspa?keywords=usb+to+uart&qid=1693041413&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1) from Amazon.
Connection to the card must be done with 3 wiresatached to the J6, marked "RSVD" on the card.
![Connector](images/CLI_CONN.jpg)

1. TX(pin1) from the connector goes to RX from the adaptop
2. RX(pin2) from the connector goes to TX from the adaptor
3. GND(pin3) from the connector goes to GND from the adaptor

## Software Interface
Any serial terminal software can be used, one example is [Termite](https://termie.sourceforge.net)
If you use termite, the settings must look like in the folowing picture:
![Termite](images/Termite.jpg)
Port settings 115200-8-N-1, check append CR LF.

Type *help* and hit ENTER to get the list of commands.
Type *help \<command\>* to get details for a specific command.



