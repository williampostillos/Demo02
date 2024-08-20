using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class Rectangulo
    {


        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
         

        public int Altura { get; set; }
        public int Base { get; set; }
        public int CalcularArea()
        {
            return Base * Altura;
        }

        public int CalcularPerimetro()
        {
            return (Base * Altura) / 2;
        }
    }
}
