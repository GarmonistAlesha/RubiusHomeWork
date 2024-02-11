using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LessionRubiusAcademy
{
    public class Visitor
    {
        public string name;       
        public int id;
        public uint Sale;

        public Visitor(string visitorname, int visitorid, uint visitorSale)
        {

            name = visitorname;
            id = visitorid;
            Sale = visitorSale;

        }
        public void ShowInfo()
        {

           Console.WriteLine($"Посетитель {name} с id {id} получает скидку {Sale}" );


        }

        
    }


}




    




  

    
    