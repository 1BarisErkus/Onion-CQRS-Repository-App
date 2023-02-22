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

namespace EnocaChallengeApp.Application.Features.Queries.GetAll.GetAllFirm
{
    public class GetAllFirmQueryHandler : IRequestHandler<GetAllFirmQuery, ServiceResponse<List<FirmViewDto>>>
    {

        private readonly IFirmRepository firmRepository;
        private readonly IMapper mapper;

        public GetAllFirmQueryHandler(IFirmRepository firmRepository, IMapper mapper)
        {
            this.firmRepository = firmRepository;
            this.mapper = mapper;
        }


        public async Task<ServiceResponse<List<FirmViewDto>>> Handle(GetAllFirmQuery request, CancellationToken cancellationToken)
        {
            var firms = await firmRepository.GetAllAsync();

            var viewModel = mapper.Map<List<FirmViewDto>>(firms);

            return new ServiceResponse<List<FirmViewDto>>(viewModel);
        }

    }
}
