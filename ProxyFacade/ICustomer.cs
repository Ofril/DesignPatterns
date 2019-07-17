namespace ProxyFacade
{
    public interface ICustomer : IUserProxy
    {
        void BuyTicket();

        void ShowTickets();
    }
}