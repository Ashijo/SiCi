namespace SiCi.RepositoryTransferObject;

public interface IBaseRepositoryTransferObject
{
	public Guid Id { get; init; }
	public bool Deleted { get; init; }
	public DateTime CreationDate { get; init; }
	public DateTime? LastUpdateDate { get; init; }
	public DateTime? DeletionDate { get; init; }
}
