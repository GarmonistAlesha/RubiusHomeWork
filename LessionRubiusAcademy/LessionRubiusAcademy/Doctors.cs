using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessionRubiusAcademy
{
    public class Doctor
    {
       
        public string Name;
        public string Specialization;
        public int Age;

        public Doctor(string name, string Classification, int age)
        {
            
            Name = name;
            Specialization = Classification;
            Age = age;
        }

        public void InfoDoctor()
        {
          
            Console.WriteLine($"Доктор {Name} по направлению {Specialization} со стажем в работе {Age}");
        } // Информация о докторе

        public void HealthStatusPatient(Patient patient)
        {
            if (patient.Health == false)
            {

                Console.WriteLine($"Пациент {patient.Name} с температурой {patient.Temperature} проходит лечение");

            }
            else 
            {
                Console.WriteLine($"Пациент {patient.Name} не нуждается во врачебной помощи!!") ;
             
            }
        
        } //Статус здоровья пациента 
         public void DoctorAppointment(Patient patient)
         {

             if (patient.Health == false)
             {

                Console.WriteLine($" Врач  {Name} принимает пациента {patient.Name}!!!");
                patient.Health = true;

             }

         } //Прием доктора 
      
    }

}

