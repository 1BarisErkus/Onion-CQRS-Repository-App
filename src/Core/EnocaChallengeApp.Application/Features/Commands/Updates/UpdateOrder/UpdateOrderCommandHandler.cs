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

namespace EnocaChallengeApp.Application.Features.Commands.Updates.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, ServiceResponse<OrderViewDto>>
    {
        IOrderRepository orderRepository;
        IMapper mapper;
        public UpdateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            this.orderRepository = orderRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<OrderViewDto>> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = mapper.Map<Domain.Entities.Order>(request);
            await orderRepository.Update(order);

            var viewModel = mapper.Map<Dtos.OrderViewDto>(order);
            return new ServiceResponse<OrderViewDto>(viewModel);
        }
    }
}
