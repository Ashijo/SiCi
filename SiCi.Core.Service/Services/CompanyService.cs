using SiCi.Core.Service.Mappers;
using SiCi.Repository;
using SiCi.ServiceTransferObject;

namespace SiCi.Core.Service.Services;

public class CompanyService
{
	private readonly CompanyRepository repository;

	CompanyService(CompanyRepository _repository)
	{
		repository = _repository;
	}

	public CompanySTO Create(CompanySTO companySTO)
	{
		var rtoToAdd = companySTO.ToSO().ToRTO();
		var companyAdded = repository.Add(rtoToAdd);
		return companyAdded.ToSO().ToSTO();
	}

	public CompanySTO[] GetAll()
	{
		return repository.GetAll()
			.Select(RTOCrossSO.ToSO)
			.Select(STOCrossSO.ToSTO)
			.ToArray();
	}

	public CompanySTO Update(CompanySTO companySTO)
	{
		var companyRTO = repository.Update(companySTO.ToSO().ToRTO());
		return companyRTO.ToSO().ToSTO();
	}

	public void Delete(Guid id)
	{
		repository.Delete(id);
	}
}
