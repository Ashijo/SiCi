namespace SiCi.Core.Service.ServiceObjects;

internal interface IBaseServiceObject
{
	internal Guid Id { get; init; }
	internal bool Deleted { get; init; }
	internal DateTime CreationDate { get; init; }
	internal DateTime? LastUpdateDate { get; init; }
	internal DateTime? DeletionDate { get; init; }
}
