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
    public class CreateFirmCommand : IRequest<ServiceResponse<int>>
    {
        public string FirmName { get; set; }
        public int ApprovelStatus { get; set; }
        public DateTime OrderClearanceStartTime { get; set; }
        public DateTime OrderClearanceFinishTime { get; set; }
    }
}
