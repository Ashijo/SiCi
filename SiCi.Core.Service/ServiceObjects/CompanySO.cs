namespace SiCi.Core.Service.ServiceObjects;

public record RCompanySO(
	string Name,
	Guid Id,
	bool Deleted,
	DateTime CreationDate,
	DateTime? LastUpdateDate = null,
	DateTime? DeletionDate = null) : IBaseServiceObject;

public record RCompanySOResult(RCompanySO Company);

public record RCompaniesSOResult(RCompanySO[] Companies);

public record RCreateCompanySORequest(string Name);

public record RUpdateCompanySORequest(string Name);
