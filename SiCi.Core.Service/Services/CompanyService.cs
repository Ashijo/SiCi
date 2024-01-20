using SiCi.Core.Service.Mappers;
using SiCi.Repository;
using SiCi.ServiceTransferObject;

namespace SiCi.Core.Service.Services;

public class CompanyService(CompanyRepository _repository)
{
	public RCompanySTOResult Create(RCreateCompanySTORequest companySTO)
	{
		var rtoToAdd = companySTO.ToSO().ToRTO();
		var companyAdded = _repository.Add(rtoToAdd);
		return companyAdded.ToSO().ToSTO();
	}

	public RCompaniesSTOResult GetAll()
	{
		return _repository.GetAll()
			.ToSO()
			.ToSTO();
	}

	public RCompanySTOResult Update(Guid id, RUpdateCompanySTORequest companySTO)
	{
		var companyRTO = _repository.Update(id, companySTO.ToSO().ToRTO());
		return companyRTO.ToSO().ToSTO();
	}

	public void Delete(Guid id)
	{
		_repository.Delete(id);
	}
}
