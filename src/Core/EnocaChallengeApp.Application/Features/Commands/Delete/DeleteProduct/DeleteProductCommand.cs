using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Delete.DeleteProduct
{
    public class DeleteProductCommand : IRequest<ServiceResponse<int>>
    {
        public int Id { get; set; }
    }
}
