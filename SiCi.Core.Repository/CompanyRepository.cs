using SiCi.Domain;
using SiCi.Repository.Mappers;
using SiCi.RepositoryTransferObject;

namespace SiCi.Repository;

public class CompanyRepository : BaseRepository<Company>
{
	public RCompanyRTOResult? Get(Guid id)
	{
		//TODO: Fix possible null reference
		return GetById(id).ToRTO();
	}

	public RCompaniesRTOResult GetAll()
	{
		return GetAllNotDeleted().ToRTO();
	}

	public RCompanyRTOResult Add(RCreateCompanyRTORequest request)
	{
		var model = new Company { Name = request.Name };

		var addedModel = Add(model);
		return addedModel.ToRTO();
	}

	public RCompanyRTOResult Update(Guid id, RUpdateCompanyRTORequest request)
	{
		var model = GetById(id);
		model.Name = request.Name;
		var updatedModel = Update(model);
		return updatedModel.ToRTO();
	}

	public void Delete(Guid id)
	{
		SoftDelete(id);
	}
}
