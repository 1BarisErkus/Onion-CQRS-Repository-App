using EnocaChallengeApp.Application.Dtos;
using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Queries.GetById.GetFirmById
{
    public class GetFirmByIdQuery : IRequest<ServiceResponse<FirmViewDto>>
    {
        public int Id { get; set; }

    }
}
