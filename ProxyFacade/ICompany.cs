namespace ProxyFacade
{
    public interface ICompany : IUserProxy
    {
        void CreateFlight();

        void CancelFlight();
    }
}