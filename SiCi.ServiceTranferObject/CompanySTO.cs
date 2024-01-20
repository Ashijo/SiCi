namespace SiCi.ServiceTransferObject;

public record RCompanySTO(
	string Name,
	Guid Id,
	bool Deleted,
	DateTime CreationDate,
	DateTime? LastUpdateDate = null,
	DateTime? DeletionDate = null) : IBaseServiceTransferObject;

public record RCompanySTOResult(RCompanySTO Company);

public record RCompaniesSTOResult(RCompanySTO[] Companies);

public record RCreateCompanySTORequest(string Name);

public record RUpdateCompanySTORequest(string Name);
