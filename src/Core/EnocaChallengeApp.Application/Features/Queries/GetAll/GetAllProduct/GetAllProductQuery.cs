using EnocaChallengeApp.Application.Dtos;
using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Queries.GetAll.GetAllProduct
{
    public class GetAllProductQuery : IRequest<ServiceResponse<List<ProductViewDto>>>
    {
    }
}
