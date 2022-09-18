using CQRSWithMediator.Commands;
using CQRSWithMediator.Dtos;
using CQRSWithMediator.Entities;

namespace CQRSWithMediator.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<CustomerDto> _customers = new();
        public DataAccess()
        {
            _customers.Add(new CustomerDto() {Id = 1, CustomerName = "siddhi",Address = "ktm",MobileNo="9834561293"});
            _customers.Add(new CustomerDto() {Id = 2, CustomerName = "krishna",Address = "ktm",MobileNo="9834561295"});
        }
        public CustomerDto AddCustomer(AddCustomerCommand customer)
        {
            CustomerDto customerDto = new()
            {
                Id = _customers.Max(x => x.Id) + 1,
                CustomerName = customer.CustomerName,
                Address = customer.Address,
                MobileNo = customer.MobileNo,
            };
            _customers.Add(customerDto);

            return customerDto;
        }

        public List<CustomerDto> GetCustomerList()
        {
            return _customers;
        }
    }
}
