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

namespace EnocaChallengeApp.Application.Features.Queries.GetAll.GetAllOrder
{
    public class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQuery, ServiceResponse<List<OrderViewDto>>>
    {
        private readonly IOrderRepository orderRepository;
        private readonly IMapper mapper;

        public GetAllOrderQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            this.orderRepository = orderRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<List<OrderViewDto>>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
        {
            var orders = await orderRepository.GetAllAsync();
            var viewModel = mapper.Map<List<OrderViewDto>>(orders);

            return new ServiceResponse<List<OrderViewDto>>(viewModel);
        }
    }
}
