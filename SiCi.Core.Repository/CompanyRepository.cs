using SiCi.Core.Service.Mappers;
using SiCi.Domain;
using SiCi.RepositoryTransferObject;

namespace SiCi.Repository;

public class CompanyRepository : BaseRepository<Company>
{
	public CompanyRTO? Get(Guid id)
	{
		//TODO: Fix possible null reference
		return GetById(id).ToRTO();
	}

	public CompanyRTO[] GetAll()
	{
		return GetAllNotDeleted()
			.Select(RTOCrossModel.ToRTO)
			.ToArray();
	}

	public CompanyRTO Add(CompanyRTO company)
	{
		var model = company.ToModel();
		var addedModel = Add(model);
		return addedModel.ToRTO();
	}

	public CompanyRTO Update(CompanyRTO company)
	{
		var model = company.ToModel();
		var updatedModel = Update(model);
		return updatedModel.ToRTO();
	}

	public void Delete(Guid id)
	{
		SoftDelete(id);
	}
}
