using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Examen
{
    public class Conversion
    {
        
            public double Monto { get; set; }
            public string Moneda { get; set; }
            
            public double Conv { get; set; }


            public Conversion()
            {
                this.Monto = 0;
                this.Moneda = "";
                 this.Conv = 0;
            }
            public Conversion(string Moneda, double Monto,double Conv)
            {
                this.Moneda = Moneda;
                this.Monto= Monto;
                    this.Conv = 0;
           
               
            }
        
    }
}
