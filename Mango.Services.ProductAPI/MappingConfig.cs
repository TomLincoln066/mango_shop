﻿using AutoMapper;
using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Models;
using System.Reflection.Metadata.Ecma335;

namespace Mango.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }

        
    }
}
