namespace SiCi.Contract.Company;

public record Company(
	string Name,
	Guid Id,
	bool Deleted,
	DateTime CreationDate,
	DateTime? LastUpdateDate,
	DateTime? DeletionDate) : IContractModel;
