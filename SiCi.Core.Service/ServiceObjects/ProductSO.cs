namespace SiCi.Core.Service.ServiceObjects;

internal class ProductSO : IBaseServiceObject
{
	public string Name { get; set; }
	public Guid Id { get; set; }
	public bool Deleted { get; set; }
	public DateTime CreationDate { get; set; }
	public DateTime LastUpdateDate { get; set; }
	public DateTime DeletionDate { get; set; }
}
