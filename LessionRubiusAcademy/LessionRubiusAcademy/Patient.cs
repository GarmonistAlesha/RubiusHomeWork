using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessionRubiusAcademy
{
    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Temperature { get; set; }
        public bool Health { get; set; }


        public Patient(string PatientName, int PatientAge, double PatientTemp)
        {

            Name = PatientName;
            Age = PatientAge;
            Temperature = PatientTemp;

        }

        public void StatusPatient()    // Общаяя информация о пациенте
        {

            Console.WriteLine($"Пациент{Name},которому {Age} лет,с температурой {Temperature}");
        }    

        public void StatusTempPatient(Patient patient)   //Проверка температуры пациента 
        {
            if (Temperature > 36.6)
            {

                Console.WriteLine($"Пациент {Name} простужен!!!");
                Health = false;

            }
            else
            {

                Console.WriteLine($"У пациента{Name} отсутствует температура!!!");
                Health = true;

            }
        }

        public void StatusHealthPatient(Patient patient) 
        { 
       
            if(Health== true) 
            {

                Console.WriteLine($"Пациент {Name} жив и здоров!!!") ;

            }

        
        } // Статус пациента после приема врача

   
    }


}
