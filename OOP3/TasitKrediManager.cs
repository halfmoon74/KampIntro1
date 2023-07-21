using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme planı hesaplandı");
        }

        public void Yazdir()
        {
            throw new NotImplementedException();
        }
    }
}
