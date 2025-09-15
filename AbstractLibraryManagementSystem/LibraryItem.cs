using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLibraryManagementSystem
{
    public abstract class LibraryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }

        public abstract void ShowInfo();
    }
}
