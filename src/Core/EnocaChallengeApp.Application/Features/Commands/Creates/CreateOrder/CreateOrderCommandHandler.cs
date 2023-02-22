using AutoMapper;
using EnocaChallengeApp.Application.Interfaces.Repository;
using EnocaChallengeApp.Application.Wrappers;
using EnocaChallengeApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Creates.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, ServiceResponse<string>>
    {
        IOrderRepository orderRepository;
        IFirmRepository firmRepository;
        private readonly IMapper mapper;

        public CreateOrderCommandHandler(IOrderRepository orderRepository, IFirmRepository firmRepository, IMapper mapper)
        {
            this.orderRepository = orderRepository;
            this.mapper = mapper;
            this.firmRepository = firmRepository;
        }

        public async Task<ServiceResponse<string>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = mapper.Map<Order>(request);

            Firm firm = await firmRepository.GetByIdAsync(order.FirmId);
            if (firm.ApprovelStatus == 0)
            {
                return new ServiceResponse<string>("Firma izni bulunmamaktadır");
            }
            else
            {
                if (order.Date_.Hour > firm.OrderClearanceStartTime.Hour && order.Date_.Hour < firm.OrderClearanceFinishTime.Hour)
                {
                    await orderRepository.AddAsync(order);
                    return new ServiceResponse<string>("Sipariş oluşturuldu");

                }
                else if (order.Date_.Hour == firm.OrderClearanceStartTime.Hour)
                {
                    if (order.Date_.Minute > firm.OrderClearanceStartTime.Minute)
                    {
                        await orderRepository.AddAsync(order);
                        return new ServiceResponse<string>("Sipariş oluşturuldu");
                    }
                    else
                    {
                        return new ServiceResponse<string>("Firma izin saatleri dışında sipariş oluşturmaya çalıştınız.");
                    }
                }
                else if (order.Date_.Hour == firm.OrderClearanceFinishTime.Hour)
                {
                    if (order.Date_.Minute < firm.OrderClearanceFinishTime.Minute)
                    {
                        await orderRepository.AddAsync(order);
                        return new ServiceResponse<string>("Sipariş oluşturuldu");
                    }
                    else
                    {
                        return new ServiceResponse<string>("Firma izin saatleri dışında sipariş oluşturmaya çalıştınız.");
                    }
                }
                else
                {
                    return new ServiceResponse<string>("Firma izin saatleri dışında sipariş oluşturmaya çalıştınız.");
                }
            }
        }
    }
}
