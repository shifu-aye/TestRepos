using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Test
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void Authentication(string login, string password);

        [OperationContract]
        void CoordR(string screenPosition);
        [OperationContract]
        void CoordL(string screenPosition);
        [OperationContract]
        void CoordU(string screenPosition);
        [OperationContract]
        void CoordD(string screenPosition);
        [OperationContract]
        void CoordMouseL(string screenPosition);
        [OperationContract]
        void CoordMouseR(string screenPosition);
        [OperationContract]
        void CoordMouseM(string screenPosition);

        [OperationContract]
        void SendEmail(int counter);

        [OperationContract]
        void SendWhatsApp(int counter);
    }
}
