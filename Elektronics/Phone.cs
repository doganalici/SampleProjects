using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronics
{
    public class Phone:Product
    {
        public string Camera { get; set; }

        public void TakePhoto()
        {
            Console.WriteLine($"{Brand} marka telefondan resim çekilmiştr");
        }
    }
}
