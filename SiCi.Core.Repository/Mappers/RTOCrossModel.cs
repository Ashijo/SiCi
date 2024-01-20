using SiCi.Domain;
using SiCi.RepositoryTransferObject;

namespace SiCi.Repository.Mappers;

internal static class RTOCrossModel
{
	private static RCompanyRTO CompanyToRTOObject(this Company model)
	{
		return new RCompanyRTO(
			model.Name,
			model.Id,
			model.Deleted,
			model.CreationDate,
			model.LastUpdateDate,
			model.DeletionDate);
	}

	internal static RCompanyRTOResult ToRTO(this Company model)
	{
		return new RCompanyRTOResult(
			model.CompanyToRTOObject());
	}

	internal static RCompaniesRTOResult ToRTO(this Company[] models)
	{
		return new RCompaniesRTOResult(
			models.Select(CompanyToRTOObject).ToArray());
	}

	// internal static Company ToModel(this RCreateCompanyRTORequest rto)
	// {
	// 	return new Company
	// 	{
	// 		Id = rto.Id,
	// 		Name = rto.Name,
	// 		Deleted = rto.Deleted,
	// 		CreationDate = rto.CreationDate,
	// 		LastUpdateDate = rto.LastUpdateDate,
	// 		DeletionDate = rto.DeletionDate
	// 	};
	// }
}
