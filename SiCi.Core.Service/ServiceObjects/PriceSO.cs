namespace SiCi.Core.Service.ServiceObjects;

public class PriceSO : IBaseServiceObject
{
	public decimal Value { get; set; }
	public ProductSO ProductSo { get; set; }
	public ShopSO ShopSo { get; set; }
	public Guid Id { get; set; }
	public bool Deleted { get; set; }
	public DateTime CreationDate { get; set; }
	public DateTime LastUpdateDate { get; set; }
	public DateTime DeletionDate { get; set; }
}
