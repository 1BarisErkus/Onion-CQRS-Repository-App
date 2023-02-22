using AutoMapper;
using EnocaChallengeApp.Application.Dtos;
using EnocaChallengeApp.Application.Interfaces.Repository;
using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Queries.GetById.GetFirmById
{
    public class GetFirmByIdQueryHandler : IRequestHandler<GetFirmByIdQuery, ServiceResponse<FirmViewDto>>
    {
        IFirmRepository firmRepository;
        private readonly IMapper mapper;

        public GetFirmByIdQueryHandler(IFirmRepository firmRepository, IMapper mapper)
        {
            this.firmRepository = firmRepository;
            this.mapper = mapper;

        }

        public async Task<ServiceResponse<FirmViewDto>> Handle(GetFirmByIdQuery request, CancellationToken cancellationToken)
        {
            var firm = await firmRepository.GetByIdAsync(request.Id);
            var dto = mapper.Map<FirmViewDto>(firm);

            return new ServiceResponse<FirmViewDto>(dto);
        }
    }
}
