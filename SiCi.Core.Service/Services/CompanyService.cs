using SiCi.Core.Service.Mappers;
using SiCi.Repository;
using SiCi.ServiceTransferObject;

namespace SiCi.Core.Service.Services;

public class CompanyService(CompanyRepository _repository)
{
	public CompanySTO Create(CompanySTO companySTO)
	{
		var rtoToAdd = companySTO.ToSO().ToRTO();
		var companyAdded = _repository.Add(rtoToAdd);
		return companyAdded.ToSO().ToSTO();
	}

	public CompanySTO[] GetAll()
	{
		return _repository.GetAll()
			.Select(RTOCrossSO.ToSO)
			.Select(STOCrossSO.ToSTO)
			.ToArray();
	}

	public CompanySTO Update(CompanySTO companySTO)
	{
		var companyRTO = _repository.Update(companySTO.ToSO().ToRTO());
		return companyRTO.ToSO().ToSTO();
	}

	public void Delete(Guid id)
	{
		_repository.Delete(id);
	}
}
