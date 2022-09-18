using CQRSWithMediator.Commands;
using CQRSWithMediator.DataAccess;
using CQRSWithMediator.Dtos;
using MediatR;

namespace CQRSWithMediator.Handlers
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, CustomerDto>
    {
        private readonly IDataAccess _dataAccess;

        public AddCustomerCommandHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<CustomerDto> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_dataAccess.AddCustomer(request));
        }
    }
}
