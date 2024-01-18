namespace SiCi.Contract;

public class Price : IBaseContract
{
	public decimal Value { get; set; }
	public Product Product { get; set; }
	public Shop Shop { get; set; }
	public Guid? Id { get; set; }
	public bool Deleted { get; set; }
	public DateTime CreationDate { get; set; }
	public DateTime LastUpdateDate { get; set; }
	public DateTime DeletionDate { get; set; }
}
