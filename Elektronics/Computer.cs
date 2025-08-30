using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Elektronics
{
    public class Computer : Product
    {
        public int RAM { get; set; }
        public bool RGBKeyboard { get; set; }

        public void ComputersInfo()
        { 
            Console.WriteLine($"RAM : {RAM}");
            if (RGBKeyboard == false)
            {
                Console.WriteLine("RGB klavye : YOK");
            }
            else
            {
                Console.WriteLine("RGB klavye : VAR");
            }
        }
        public void RunProgram(string ProgramName)
        {
            Console.WriteLine($"{Brand} marka bilgisayarda {ProgramName} programı çalıştırılmıştır");
        }
    }
}
