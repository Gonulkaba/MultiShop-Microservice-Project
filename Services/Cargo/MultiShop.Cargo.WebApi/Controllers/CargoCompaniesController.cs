using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoCompanyDto;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CargoCompaniesController : ControllerBase
	{
		private readonly ICargoCompanyService _cargoCompanyService;
		private readonly IMapper _mapper;

		public CargoCompaniesController(ICargoCompanyService cargoCompanyService, IMapper mapper)
		{
			_cargoCompanyService = cargoCompanyService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult CargoCompanyList()
		{
			var values = _cargoCompanyService.TGetAll();
			var result = _mapper.Map<List<ResultCargoCompanyDto>>(values);
			return Ok(result);
		}

		[HttpPost]
		public IActionResult CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto)
		{
			var value = _mapper.Map<CargoCompany>(createCargoCompanyDto);
			_cargoCompanyService.TInsert(value);
			return Ok();
		}

		[HttpDelete]
		public IActionResult RemoveCargoCompany(int id)
		{
			_cargoCompanyService.TDelete(id);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoCompanyById(int id)
		{
			var value = _cargoCompanyService.TGetById(id);
			var result = _mapper.Map<ResultCargoCompanyDto>(value);
			return Ok(result);
		}

		[HttpPut]
		public IActionResult UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto)
		{
			var value = _mapper.Map<CargoCompany>(updateCargoCompanyDto);
			_cargoCompanyService.TUpdate(value);
			return Ok();
		}
	}
}
