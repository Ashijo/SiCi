namespace SiCi.ServiceTransferObject;

public class PriceSTO : IBaseServiceTransfereObject
{
	public decimal Value { get; set; }
	public ProductSTO ProductSto { get; set; }
	public ShopSTO ShopSto { get; set; }
	public Guid Id { get; set; }
	public bool Deleted { get; set; }
	public DateTime CreationDate { get; set; }
	public DateTime LastUpdateDate { get; set; }
	public DateTime DeletionDate { get; set; }
}
