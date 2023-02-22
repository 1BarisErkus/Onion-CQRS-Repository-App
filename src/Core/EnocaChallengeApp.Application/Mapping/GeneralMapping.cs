using AutoMapper;
using EnocaChallengeApp.Application.Dtos;
using EnocaChallengeApp.Application.Features.Commands.Creates.CreateFirm;
using EnocaChallengeApp.Application.Features.Commands.Creates.CreateOrder;
using EnocaChallengeApp.Application.Features.Commands.Creates.CreateProduct;
using EnocaChallengeApp.Application.Features.Commands.Delete.DeleteFirm;
using EnocaChallengeApp.Application.Features.Commands.Delete.DeleteOrder;
using EnocaChallengeApp.Application.Features.Commands.Delete.DeleteProduct;
using EnocaChallengeApp.Application.Features.Commands.Updates.UpdateFirm;
using EnocaChallengeApp.Application.Features.Commands.Updates.UpdateOrder;
using EnocaChallengeApp.Application.Features.Commands.Updates.UpdateProduct;
using EnocaChallengeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Firm, FirmViewDto>().ReverseMap();
            CreateMap<Order, OrderViewDto>().ReverseMap();
            CreateMap<Product, ProductViewDto>().ReverseMap();

            CreateMap<Firm, CreateFirmCommand>().ReverseMap();
            CreateMap<Order, CreateOrderCommand>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();

            CreateMap<Firm, UpdateFirmCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
            CreateMap<Product, UpdateProductCommand>().ReverseMap();

            CreateMap<Firm, DeleteFirmCommand>().ReverseMap();
            CreateMap<Order, DeleteOrderCommand>().ReverseMap();
            CreateMap<Product, DeleteProductCommand>().ReverseMap();
        }
    }
}
