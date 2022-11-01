﻿using System;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.ServiceModel;
using Test.Data.Context;
using Test.Data.Tables;

namespace Test
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service" в коде и файле конфигурации.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service : IService
    {
        public void Authentication(string login, string password)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Console.WriteLine($"{DateTime.UtcNow}: Подключение к бд...");
                User currentUser = null;
                currentUser = db.Users.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
                if (!currentUser.IsAdmin)
                {
                    Console.WriteLine($"{DateTime.UtcNow}: Клиет вошел, как пользователь!");
                }
                else
                {
                    Console.WriteLine($"{DateTime.UtcNow}: Клиет вошел, как пользователь!");
                }
            }
        }

        public void CoordD(string screenPosition)
        {
            Console.WriteLine($"{DateTime.UtcNow}: Сдвиг вниз на 10px {screenPosition}");
        }

        public void CoordL(string screenPosition)
        {
            Console.WriteLine($"{DateTime.UtcNow}: Сдвиг влево на 10px {screenPosition}");
        }

        public void CoordMouseL(string screenPosition)
        {
            Console.WriteLine($"{DateTime.UtcNow}: Левая кнопка мыши на 10px {screenPosition}");
        }

        public void CoordMouseM(string screenPosition)
        {
            Console.WriteLine($"{DateTime.UtcNow}: Средняя кнопка мыши на 10px {screenPosition}");
        }

        public void CoordMouseR(string screenPosition)
        {
            Console.WriteLine($"{DateTime.UtcNow}: Правая кнопка мыши на 10px {screenPosition}");
        }

        public void CoordR(string screenPosition)
        {
            Console.WriteLine($"{DateTime.UtcNow}: Сдвиг вправо на 10px {screenPosition}");
        }

        public void CoordU(string screenPosition)
        {
            Console.WriteLine($"{DateTime.UtcNow}: Сдвиг наверх на 10px {screenPosition}");
        }

        public void SendEmail(int counter)
        {
            //using (testDBEntities db = new testDBEntities())
            //{
                //emailAdress = db.UsersTable.Find(id).EmailAdress;
                MailAddress from = new MailAddress("test4123mail@gmail.com", "Алексей");
                MailAddress to = new MailAddress("juliakarnauh1975@gmail.com");
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Количество записей";
                m.Body = $"<h2>Количество записей: {counter}</h2>";
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("test4123mail@gmail.com", "qsseagcpmtmpgdju");
                smtp.EnableSsl = true;
                smtp.Send(m);
                Console.WriteLine($"{DateTime.UtcNow}: Письмо на почту отправлено");
            //}
            
        }

        public void SendWhatsApp(int counter)
        {
            string message = counter.ToString();
            string number = "+79393192557";
            System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + number + "&text=" + message);
            Console.WriteLine($"{DateTime.UtcNow}: Письмо в WhatsApp отправлено");
        }
    }
}
