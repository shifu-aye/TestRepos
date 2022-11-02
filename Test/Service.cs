using System;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.ServiceModel;
using Test.Data.Context;
using Test.Data.Tables;
using System.ComponentModel;

namespace Test
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service" в коде и файле конфигурации.
   
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service : IService
    {
        public void Authentication1(string login, string password)
        {
            // Дальше ошибка
            using (ApplicationContext db = new ApplicationContext())
            {
                Console.WriteLine($"{DateTime.Now}: Подключение к бд...");
                User currentUser = null;
                currentUser = db.Users.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
                if (!currentUser.IsAdmin)
                {
                    Console.WriteLine($"{DateTime.Now}: Клиент вошел, как пользователь!");
                }
                else
                {
                    Console.WriteLine($"{DateTime.Now}: Клиент вошел, как Админ!");
                }
            }
        }

        public void CoordD(string screenPosition)
        {
            Console.WriteLine($"{DateTime.Now}: Сдвиг вниз на 10px {screenPosition}");
        }

        public void CoordL(string screenPosition)
        {
            Console.WriteLine($"{DateTime.Now}: Сдвиг влево на 10px {screenPosition}");
        }

        public void CoordMouseL(string screenPosition)
        {
            Console.WriteLine($"{DateTime.Now}: Левая кнопка мыши {screenPosition}");
        }

        public void CoordMouseM(string screenPosition)
        {
            Console.WriteLine($"{DateTime.Now}: Средняя кнопка мыши {screenPosition}");
        }

        public void CoordMouseR(string screenPosition)
        {
            Console.WriteLine($"{DateTime.Now}: Правая кнопка мыши {screenPosition}");
        }

        public void CoordR(string screenPosition)
        {
            Console.WriteLine($"{DateTime.Now}: Сдвиг вправо на 10px {screenPosition}");
        }

        public void CoordU(string screenPosition)
        {
            Console.WriteLine($"{DateTime.Now}: Сдвиг наверх на 10px {screenPosition}");
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
                Console.WriteLine($"{DateTime.Now}: Письмо на почту отправлено");
            //}
            
        }

        public void SendWhatsApp(int counter)
        {
            string message = counter.ToString();
            string number = "+79393192557";
            System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + number + "&text=" + message);
            Console.WriteLine($"{DateTime.Now}: Письмо в WhatsApp отправлено");
        }
    }
}
