using EnocaChallengeApp.Application.Dtos;
using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Updates.UpdateProduct
{
    public class UpdateProductCommand : IRequest<ServiceResponse<ProductViewDto>>
    {
        public int Id { get; set; } = -1;
        public int FirmId { get; set; } = -1;
        public string ProductName { get; set; } = "";
        public int Price { get; set; } = -1;
    }
}
