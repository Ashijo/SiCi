using SiCi.Core.Service.ServiceObjects;
using SiCi.RepositoryTransferObject;

namespace SiCi.Core.Service.Mappers;

internal static class RTOCrossSO
{
	private static RCompanySO ToSO(this RCompanyRTO rto)
	{
		return new RCompanySO(
			rto.Name,
			rto.Id,
			rto.Deleted,
			rto.CreationDate,
			rto.LastUpdateDate,
			rto.DeletionDate);
	}

	internal static RCompanySOResult ToSO(this RCompanyRTOResult rto)
	{
		return new RCompanySOResult(
			rto.Company.ToSO());
	}

	internal static RCompaniesSOResult ToSO(this RCompaniesRTOResult rto)
	{
		return new RCompaniesSOResult(
			rto.Companies.Select(ToSO).ToArray());
	}


	internal static RCreateCompanyRTORequest ToRTO(this RCreateCompanySORequest so)
	{
		return new RCreateCompanyRTORequest(so.Name);
	}

	internal static RUpdateCompanyRTORequest ToRTO(this RUpdateCompanySORequest so)
	{
		return new RUpdateCompanyRTORequest(so.Name);
	}
}
