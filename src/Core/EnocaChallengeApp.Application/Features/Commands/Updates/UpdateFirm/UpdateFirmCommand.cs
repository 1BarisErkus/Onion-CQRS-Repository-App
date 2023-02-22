using EnocaChallengeApp.Application.Dtos;
using EnocaChallengeApp.Application.Wrappers;
using EnocaChallengeApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Updates.UpdateFirm
{
    public class UpdateFirmCommand : IRequest<ServiceResponse<FirmViewDto>>
    {
        public int Id { get; set; } = -1;
        public string FirmName { get; set; } = "";
        public int ApprovelStatus { get; set; } = -1;
        public DateTime OrderClearanceStartTime { get; set; }
        public DateTime OrderClearanceFinishTime { get; set; }
    }
}
