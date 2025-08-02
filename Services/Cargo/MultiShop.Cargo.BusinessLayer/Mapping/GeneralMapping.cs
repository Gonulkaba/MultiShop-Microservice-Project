using AutoMapper;
using MultiShop.Cargo.DtoLayer.Dtos.CargoCompanyDto;
using MultiShop.Cargo.DtoLayer.Dtos.CargoCustomerDtos;
using MultiShop.Cargo.DtoLayer.Dtos.CargoDetailDtos;
using MultiShop.Cargo.DtoLayer.Dtos.CargoOperationDtos;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BusinessLayer.Mapping
{
	public class GeneralMapping : Profile
	{
		public GeneralMapping()
		{
			CreateMap<CargoCompany, ResultCargoCompanyDto>().ReverseMap();
			CreateMap<CargoCompany, UpdateCargoCompanyDto>().ReverseMap();
			CreateMap<CargoCompany, CreateCargoCompanyDto>().ReverseMap();

			CreateMap<CargoCustomer, ResultCargoCustomerDto>().ReverseMap();
			CreateMap<CargoCustomer, UpdateCargoCustomerDto>().ReverseMap();
			CreateMap<CargoCustomer, CreateCargoCustomerDto>().ReverseMap();

			CreateMap<CargoDetail, ResultCargoDetailDto>().ReverseMap();
			CreateMap<CargoDetail, UpdateCargoDetailDto>().ReverseMap();
			CreateMap<CargoDetail, CreateCargoDetailDto>().ReverseMap();

			CreateMap<CargoOperation, ResultCargoOperationDto>().ReverseMap();
			CreateMap<CargoOperation, UpdateCargoOperationDto>().ReverseMap();
			CreateMap<CargoOperation, CreateCargoOperationDto>().ReverseMap();
		}
	}
}
