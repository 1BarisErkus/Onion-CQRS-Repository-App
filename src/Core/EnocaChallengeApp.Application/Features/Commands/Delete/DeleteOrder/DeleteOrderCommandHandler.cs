using AutoMapper;
using EnocaChallengeApp.Application.Interfaces.Repository;
using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Delete.DeleteOrder
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, ServiceResponse<int>>
    {
        IOrderRepository orderRepository;
        IMapper mapper;
        public DeleteOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            this.orderRepository = orderRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<int>> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var order = mapper.Map<Domain.Entities.Order>(request);
            await orderRepository.Delete(order);

            return new ServiceResponse<int>(order.Id);
        }
    }
}
