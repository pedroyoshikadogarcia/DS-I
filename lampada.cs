using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada
{
    public class Lampada
    {
        public int lampadaNro;
        public string comodo;
        public bool status;

        public void provarExistencia()
        {
            Console.WriteLine("Oi, eu existo!\n");
        }
        public static void Main(string[] args)
        {
            Lampada l1 = new Lampada();

            l1.lampadaNro = 1;
            l1.comodo = "Quarto";
            l1.status = true;

            l1.provarExistencia();
            Console.WriteLine(l1.lampadaNro);
            Console.WriteLine(l1.comodo);
            Console.WriteLine(l1.status);

            Lampada l2 = new Lampada();

            l2.lampadaNro = 3;
            l2.comodo = "sala";
            l2.status = false;

            Console.WriteLine(l2.lampadaNro);
            Console.WriteLine(l2.comodo);
            Console.WriteLine(l2.status);
        }
    }
}
