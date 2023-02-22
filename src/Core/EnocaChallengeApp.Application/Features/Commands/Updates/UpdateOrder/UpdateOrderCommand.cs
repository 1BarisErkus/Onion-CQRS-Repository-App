﻿using EnocaChallengeApp.Application.Dtos;
using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Updates.UpdateOrder
{
    public class UpdateOrderCommand : IRequest<ServiceResponse<OrderViewDto>>
    {
        public int Id { get; set; } = -1; 
        public int FirmId { get; set; } = -1;
        public int ProductId { get; set; } = -1;
        public string CustomerName { get; set; } = "";
        public DateTime Date_ { get; set; }
    }
}
