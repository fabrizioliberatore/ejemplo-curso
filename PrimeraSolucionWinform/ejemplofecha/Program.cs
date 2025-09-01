using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplofecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2004,4,1);

            Console.WriteLine(fecha.ToString("dd/MM/yyyy"));
        }
    }
}
