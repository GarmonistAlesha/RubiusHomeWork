using System.Security.Cryptography.X509Certificates;

namespace LessionRubiusAcademy
{
    public class Program
    {
   
        public static void Main()
        {
            //Пациенты
            var Viktor = new Patient("Антонов Виктор Валерьевич", 38, 37);
            var Boris= new Patient("Виктюк Борис Романович", 2, 38.7);
            var Lidiya = new Patient(" Коштанова Лидия Михайловна", 78, 36.4);

            // Доктора
            var DrGalayda = new Doctor("Галайда Семен Анатольевич","Терапевт",28);;
            var DrNaguchev = new Doctor(  "Нагучев Виктор Романович", "Хирург", 45);
            var DrLukasheva = new Doctor( "Лукашева Лилия Филлиповна","Терапевт" , 58);

            
            Viktor.StatusTempPatient(Viktor);            
            Boris.StatusTempPatient(Boris);
            Lidiya.StatusTempPatient(Lidiya);

            DrGalayda.HealthStatusPatient(Viktor);
            DrNaguchev.HealthStatusPatient(Boris);
            DrLukasheva.HealthStatusPatient(Lidiya);
            
            DrGalayda.DoctorAppointment(Viktor);
            DrNaguchev.DoctorAppointment(Boris);
            DrLukasheva.DoctorAppointment(Lidiya);

            Viktor.StatusHealthPatient(Viktor);
            Boris.StatusHealthPatient(Boris);
            Lidiya.StatusHealthPatient(Lidiya);

        }


    }



 
}




