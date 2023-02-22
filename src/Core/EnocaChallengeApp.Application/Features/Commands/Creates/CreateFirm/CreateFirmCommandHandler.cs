using AutoMapper;
using EnocaChallengeApp.Application.Interfaces.Repository;
using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Creates.CreateFirm
{
    public class CreateFirmCommandHandler : IRequestHandler<CreateFirmCommand, ServiceResponse<int>>
    {
        IFirmRepository firmRepository;
        private readonly IMapper mapper;

        public CreateFirmCommandHandler(IFirmRepository firmRepository, IMapper mapper)
        {
            this.firmRepository = firmRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<int>> Handle(CreateFirmCommand request, CancellationToken cancellationToken)
        {
            var firm = mapper.Map<Domain.Entities.Firm>(request);
            await firmRepository.AddAsync(firm);

            return new ServiceResponse<int>(firm.Id);
        }
    }
}
