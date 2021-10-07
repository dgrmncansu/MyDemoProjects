using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager

    {

        //ethod injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //

           krediManager.Hesapla();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

            //hangi loger servise gönderildiyse onu logla

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
