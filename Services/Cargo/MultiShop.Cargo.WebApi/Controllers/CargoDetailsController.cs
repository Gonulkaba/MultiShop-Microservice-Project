using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoDetailDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CargoDetailsController : ControllerBase
	{
		private readonly ICargoDetailService _cargoDetailService;
		private readonly IMapper _mapper;

		public CargoDetailsController(ICargoDetailService cargoDetailService, IMapper mapper)
		{
			_cargoDetailService = cargoDetailService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult CargoDetailList()
		{
			var values = _cargoDetailService.TGetAll();
			var result = _mapper.Map<List<ResultCargoDetailDto>>(values);
			return Ok(result);
		}

		[HttpPost]
		public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
		{
			var value = _mapper.Map<CargoDetail>(createCargoDetailDto);
			_cargoDetailService.TInsert(value);
			return Ok();
		}

		[HttpDelete]
		public IActionResult RemoveCargoDetail(int id)
		{
			_cargoDetailService.TDelete(id);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoDetailById(int id)
		{
			var value = _cargoDetailService.TGetById(id);
			var result = _mapper.Map<ResultCargoDetailDto>(value);
			return Ok(result);
		}

		[HttpPut]
		public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
		{
			var value = _mapper.Map<CargoDetail>(updateCargoDetailDto);
			_cargoDetailService.TUpdate(value);
			return Ok();
		}
	}
}
