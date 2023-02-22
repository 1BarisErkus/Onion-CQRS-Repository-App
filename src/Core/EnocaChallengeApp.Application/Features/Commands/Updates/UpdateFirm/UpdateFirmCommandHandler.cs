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

namespace EnocaChallengeApp.Application.Features.Commands.Updates.UpdateFirm
{
    public class UpdateFirmCommandHandler : IRequestHandler<UpdateFirmCommand, ServiceResponse<FirmViewDto>>
    {
        IFirmRepository firmRepository;
        IMapper mapper;
        public UpdateFirmCommandHandler(IFirmRepository firmRepository, IMapper mapper)
        {
            this.firmRepository = firmRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<FirmViewDto>> Handle(UpdateFirmCommand request, CancellationToken cancellationToken)
        {
            var firm = mapper.Map<Domain.Entities.Firm>(request);
            await firmRepository.Update(firm);

            var viewModel = mapper.Map<Dtos.FirmViewDto>(firm);
            return new ServiceResponse<FirmViewDto>(viewModel);
        }
    }
}
