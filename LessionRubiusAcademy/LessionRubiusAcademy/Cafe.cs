using LessionRubiusAcademy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LessionRubiusAcademy
{
    public class Cafe
    {
        public string place;
        public string name;
        public string Food;
        public List<Visitor> visitors = new List<Visitor>();


        public Cafe(string Nazvanie)
        {
            name = Nazvanie;
        }
        public void ShowInfo()
        {

            Console.WriteLine($"В {place} находится {name} и у нее в наличии {Food}!) ");

        }
        public void GoToCafe(Visitor visitor ) 
        {
            visitors.Add(visitor);
            Console.WriteLine($"Посетитель {visitor.name} получает скидку в {name} в размере {visitor.Sale} %") ;
        }
    }



}

