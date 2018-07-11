using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;

namespace AutoWateringConsole
{
    class Program
    {
        static SerialPort _serialPort;
        static void Main(string[] args)
        {
            _serialPort = new SerialPort
            {
                PortName = "COM3",//Set your board COM
                BaudRate = 9600
            };
            _serialPort.Open();
            while (true)
            {

                string a = _serialPort.ReadLine();
                if (a != "")
                {
                    Console.WriteLine(a);
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine();
                }
            }
        }
    }
}
