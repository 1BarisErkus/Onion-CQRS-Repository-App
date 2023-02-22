using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Creates.CreateProduct
{
    public class CreateProductCommand : IRequest<ServiceResponse<int>>
    {
        public int FirmId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
