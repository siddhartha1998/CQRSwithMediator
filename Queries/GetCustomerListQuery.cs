using CQRSWithMediator.Dtos;
using MediatR;

namespace CQRSWithMediator.Queries
{
    public class GetCustomerListQuery : IRequest<List<CustomerDto>>
    {
    }
}
