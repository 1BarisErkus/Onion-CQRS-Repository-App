using EnocaChallengeApp.Application.Dtos;
using EnocaChallengeApp.Application.Wrappers;
using EnocaChallengeApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Queries.GetAll.GetAllOrder
{
    public class GetAllOrderQuery : IRequest<ServiceResponse<List<OrderViewDto>>>
    {
    }
}
