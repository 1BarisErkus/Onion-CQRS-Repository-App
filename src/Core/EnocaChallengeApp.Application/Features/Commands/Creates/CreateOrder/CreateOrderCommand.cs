using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Creates.CreateOrder
{
    public class CreateOrderCommand : IRequest<ServiceResponse<int>>
    {
        public int FirmId { get; set; }
        public int ProductId { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date_ { get; set; }
    }
}
