namespace SiCi.Core.Service.ServiceObjects;

internal interface IBaseServiceObject
{
	internal Guid? Id { get; set; }
	internal bool Deleted { get; set; }
	internal DateTime CreationDate { get; set; }
	internal DateTime LastUpdateDate { get; set; }
	internal DateTime DeletionDate { get; set; }
}
