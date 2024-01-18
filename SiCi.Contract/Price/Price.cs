namespace SiCi.Contract.Price;

public class Price : IContractModel
{
	public decimal Value { get; set; }
	public Product.Product Product { get; set; }
	public Shop.Shop Shop { get; set; }
	public Guid? Id { get; set; }
	public bool Deleted { get; set; }
	public DateTime CreationDate { get; set; }
	public DateTime LastUpdateDate { get; set; }
	public DateTime DeletionDate { get; set; }
}
