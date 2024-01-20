using SiCi.Contract.Company;
using SiCi.ServiceTransferObject;

namespace SiCi.Core.WebApi.Mappers;

internal static class STOCrossContract
{
	private static Company ToContract(this RCompanySTO sto)
	{
		return new Company(
			sto.Name,
			sto.Id,
			sto.Deleted,
			sto.CreationDate,
			sto.LastUpdateDate,
			sto.DeletionDate);
	}

	internal static RCompanyResult ToContract(this RCompanySTOResult sto)
	{
		return new RCompanyResult(
			sto.Company.ToContract());
	}

	internal static RCompaniesResult ToContract(this RCompaniesSTOResult sto)
	{
		return new RCompaniesResult(
			sto.Companies.Select(ToContract).ToArray());
	}

	internal static RCreateCompanySTORequest ToSTO(this RCreateCompanyRequest contract)
	{
		return new RCreateCompanySTORequest(contract.Name);
	}

	internal static RUpdateCompanySTORequest ToSTO(this RUpdateCompanyRequest contract)
	{
		return new RUpdateCompanySTORequest(contract.Name);
	}
}
