using System;

namespace RFID_Hopeland
{
    class Program
    {
        static void Main(string[] args)
        static RFIDReaderAPI.Param_Option PARAM_SET = new RFIDReaderAPI.Param_Option();
        static RFIDReaderAPI.RFID_Option RFID_OPTION = new RFIDReaderAPI.RFID_Option();
 
        {
            RFIDReaderAPI.Interface.IAsynchronousMessage log = new Program();
            if (RFIDReaderAPI.RFIDReader.CreateTcpConn("192.168.1.116:9090", log))
            // TCP Connect
            {
                Console.WriteLine("Create connection successfully!");
            }
            else
            {
                Console.WriteLine("Create connection failed!");
            }
        }
    }
