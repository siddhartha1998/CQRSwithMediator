using CQRSWithMediator.Commands;
using CQRSWithMediator.Dtos;
using CQRSWithMediator.Entities;

namespace CQRSWithMediator.DataAccess
{
    public interface IDataAccess
    {
        List<CustomerDto> GetCustomerList();
        CustomerDto AddCustomer(AddCustomerCommand customer);
    }
}
