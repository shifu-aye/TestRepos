using System.ServiceModel;

namespace Test
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void Authentication1(string login, string password);
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
