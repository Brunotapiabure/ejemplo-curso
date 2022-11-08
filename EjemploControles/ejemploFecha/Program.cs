using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploFecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            //DateTime fecha = new DateTime(2004, 4, 1);
            //Console.WriteLine(fecha.AddDays(5));
            Console.WriteLine(fecha.ToString("dddd MMMM yyyy"));

            //Console.WriteLine(fecha.ToShortDateString());

            Console.ReadKey();
        }
    }
}
