using System;

namespace ProxyFacade
{
    public class FlightSystemFacade : IAdmin, ICustomer, ICompany
    {
        FlightsDAO flightsDAO = new FlightsDAO(); 
        public void BuyTicket()
        {
            flightsDAO.InsertTicket();
        }

        public void CancelFlight()
        {
            flightsDAO.RemoveFlight();
        }

        public void CreateCompany()
        {
            flightsDAO.InsertCompany();
        }

        public void CreateCustomer()
        {
            flightsDAO.InsertCustomer();
        }

        public void CreateFlight()
        {
            flightsDAO.InsertFlight();
        }

        public void ShowTickets()
        {
            flightsDAO.GetTickets();
        }
    }
}