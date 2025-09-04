﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    public class Payment
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        
        public virtual void Pay()
        {
            Console.WriteLine("Ödeme yapılıyor...");
        }
    }
}
