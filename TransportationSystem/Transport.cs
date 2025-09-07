using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationSystem
{
    public class Transport
    {
        public int Id { get; set; } //sayısal Id
        public string Destination { get; set; } //varıs noktası
        public decimal Price { get; set; } //ücret 
        public DateTime TravelDate { get; set; }= DateTime.Now; //yolculuk tarihi 

        public virtual void Travel()
        {
            Console.WriteLine("Bir ulaşım işlemi gerçekleştiriliyor...");
        }
    }
}
