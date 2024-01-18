using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiCi.Contract;
using SiCi.Core.Service.Services;
using SiCi.Core.WebApi.Mappers;

namespace SiCi.Core.WebApi.Controllers;

public class CompanyController(CompanyService service) : APIControllerBase
{
	private readonly CompanyService _service = service;

	[HttpPost]
	[ProducesResponseType(StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public ActionResult<Company> Create(Company company)
	{
		var companyCreated = _service.Create(company.ToSTO());
		return CreatedAtAction(
			nameof(Create),
			new { id = companyCreated.Id },
			companyCreated);
	}

	[HttpGet]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public Company[] GetAll()
	{
		return _service.GetAll()
			.Select(STOCrossContract.ToContract)
			.ToArray();
	}

	[HttpPatch]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public Company Update(Company company)
	{
		var updatedCompany = _service.Update(company.ToSTO());
		return updatedCompany.ToContract();
	}
}
