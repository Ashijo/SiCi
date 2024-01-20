using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiCi.Contract.Company;
using SiCi.Core.Service.Services;
using SiCi.Core.WebApi.Mappers;

namespace SiCi.Core.WebApi.Controllers;

public class CompanyController(CompanyService service) : APIControllerBase
{
	private readonly CompanyService _service = service;

	[HttpPost]
	[ProducesResponseType(StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public ActionResult<RCompanyResult> Create([FromBody] RCreateCompanyRequest companyRequest)
	{
		var companyCreated = _service
			.Create(companyRequest.ToSTO())
			.ToContract();

		return CreatedAtAction(
			nameof(Create),
			new { id = companyCreated.Company.Id },
			companyCreated);
	}

	[HttpGet]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public RCompaniesResult GetAll()
	{
		return _service.GetAll().ToContract();
	}

	[HttpPatch]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[Route("{id:guid}")]
	public RCompanyResult Update([FromRoute] Guid id, [FromBody] RUpdateCompanyRequest company)
	{
		var updatedCompany = _service.Update(id, company.ToSTO());
		return updatedCompany.ToContract();
	}
}
