namespace SiCi.RepositoryTransferObject;

public record RCompanyRTO(
	string Name,
	Guid Id,
	bool Deleted,
	DateTime CreationDate,
	DateTime? LastUpdateDate = null,
	DateTime? DeletionDate = null) : IBaseRepositoryTransferObject;

public record RCompanyRTOResult(RCompanyRTO Company);

public record RCompaniesRTOResult(RCompanyRTO[] Companies);

public record RCreateCompanyRTORequest(string Name);

public record RUpdateCompanyRTORequest(string Name);
