using CQRSWithMediator.DataAccess;
using CQRSWithMediator.Dtos;
using CQRSWithMediator.Queries;
using MediatR;

namespace CQRSWithMediator.Handlers
{
    public class GetCustomerListQueryHandler : IRequestHandler<GetCustomerListQuery, List<CustomerDto>>
    {
        private readonly IDataAccess _dataAccess;

        public GetCustomerListQueryHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<CustomerDto>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
           return await Task.FromResult(_dataAccess.GetCustomerList());
        }
    }
}
