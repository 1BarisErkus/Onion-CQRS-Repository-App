using EnocaChallengeApp.Application.Wrappers;
using EnocaChallengeApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Creates.CreateOrder
{
    public class CreateOrderCommand : IRequest<ServiceResponse<string>>
    {
        public int FirmId { get; set; } = -1;
        public int ProductId { get; set; } = -1;
        public string CustomerName { get; set; } = "";
        public DateTime Date_ { get; set; }
    }
}
