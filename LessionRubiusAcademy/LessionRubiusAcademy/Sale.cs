using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LessionRubiusAcademy
{
    public class Sale
    {
        public static void Main()
        {
            var shawarma = new Cafe("Шаурма у братишки")
            {

             place = "Спальном районе",
             name  = " !Шаурма у братишки! ",
             Food = "Шаурма с курицей",

            };
            shawarma.ShowInfo();



            var Ivan = new Visitor("Ivan", 1224232312, 25);
            var Boris = new Visitor("Boris", 51654125, 15);
            var Valera = new Visitor("Valera", 415751, 10);
            var Zulick = new Visitor("Zulick", 1, 98);

            shawarma.GoToCafe(Ivan);
            shawarma.GoToCafe(Boris);
            shawarma.GoToCafe(Valera);
            shawarma.GoToCafe(Zulick);
            
        }
        
    }


}
