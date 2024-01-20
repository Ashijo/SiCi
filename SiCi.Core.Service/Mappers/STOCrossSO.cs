using SiCi.Core.Service.ServiceObjects;
using SiCi.ServiceTransferObject;

namespace SiCi.Core.Service.Mappers;

internal static class STOCrossSO
{
	private static RCompanySTO ToSTO(this RCompanySO so)
	{
		return new RCompanySTO(
			so.Name,
			so.Id,
			so.Deleted,
			so.CreationDate,
			so.LastUpdateDate,
			so.DeletionDate);
	}

	internal static RCompanySTOResult ToSTO(this RCompanySOResult so)
	{
		return new RCompanySTOResult(
			so.Company.ToSTO());
	}

	internal static RCompaniesSTOResult ToSTO(this RCompaniesSOResult so)
	{
		return new RCompaniesSTOResult(
			so.Companies.Select(ToSTO).ToArray());
	}

	internal static RCreateCompanySORequest ToSO(this RCreateCompanySTORequest sto)
	{
		return new RCreateCompanySORequest(sto.Name);
	}

	internal static RUpdateCompanySORequest ToSO(this RUpdateCompanySTORequest sto)
	{
		return new RUpdateCompanySORequest(sto.Name);
	}
}
