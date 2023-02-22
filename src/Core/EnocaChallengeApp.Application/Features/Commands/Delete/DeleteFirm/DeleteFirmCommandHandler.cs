using AutoMapper;
using EnocaChallengeApp.Application.Interfaces.Repository;
using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Delete.DeleteFirm
{
    public class DeleteFirmCommandHandler : IRequestHandler<DeleteFirmCommand, ServiceResponse<int>>
    {
        IFirmRepository firmRepository;
        IMapper mapper;
        public DeleteFirmCommandHandler(IFirmRepository firmRepository, IMapper mapper)
        {
            this.firmRepository = firmRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<int>> Handle(DeleteFirmCommand request, CancellationToken cancellationToken)
        {
            var firm = mapper.Map<Domain.Entities.Firm>(request);
            await firmRepository.Delete(firm);

            return new ServiceResponse<int>(firm.Id);
        }
    }
}
