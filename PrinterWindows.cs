using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PrinterWindows
    {
        public string Name { get; set; }
        public virtual void Show()
        {
            Console.WriteLine(" ");
        }
        public virtual void Print()
        {
            Console.WriteLine(" ");
        }
    }
}
