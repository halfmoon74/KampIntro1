using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyaykredimanager = new IhtiyacKrediManager();
            
            IKrediManager tasitKrediManager = new TasitKrediManager();
           
            IKrediManager konutkredimanager = new KonutKrediManager();

            ILoggerService databaseLoggerservice = new DataBaseLoggerService();
            


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyaykredimanager, databaseLoggerservice);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyaykredimanager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
