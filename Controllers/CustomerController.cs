using CQRSWithMediator.Commands;
using CQRSWithMediator.Dtos;
using CQRSWithMediator.Entities;
using CQRSWithMediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSWithMediator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("addCustomer")]
        public async Task<CustomerDto> AddCustomer(AddCustomerCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpGet("GetCustomer")]
        public async Task<List<CustomerDto>> GetCustomerList()
        {
            var query = new GetCustomerListQuery();
            return await _mediator.Send(query);
        }
    }
}
