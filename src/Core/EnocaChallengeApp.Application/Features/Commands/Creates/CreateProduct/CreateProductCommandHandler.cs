using AutoMapper;
using EnocaChallengeApp.Application.Features.Commands.Creates.CreateOrder;
using EnocaChallengeApp.Application.Interfaces.Repository;
using EnocaChallengeApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Features.Commands.Creates.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<int>>
    {
        IProductRepository productRepository;
        private readonly IMapper mapper;
        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = mapper.Map<Domain.Entities.Product>(request);
            await productRepository.AddAsync(product);

            return new ServiceResponse<int>(product.Id);
        }
    }
}
