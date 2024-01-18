namespace SiCi.Domain;

public class PriceRTO : IBaseRepositoryTransfereObject
{
	public decimal Value { get; set; }
	public ProductRTO ProductRto { get; set; }
	public ShopRTO ShopRto { get; set; }
	public Guid Id { get; set; }
	public bool Deleted { get; set; }
	public DateTime CreationDate { get; set; }
	public DateTime LastUpdateDate { get; set; }
	public DateTime DeletionDate { get; set; }
}
