using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection 
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerService)
        {
            //Başvuran bilgilerini değerlendirme 
            //
            
          
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler )
        {
           foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
                     
        }
    }
}
