using CQRSWithMediator.Dtos;
using MediatR;

namespace CQRSWithMediator.Commands
{
    public class AddCustomerCommand : IRequest<CustomerDto>
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
    }
}
