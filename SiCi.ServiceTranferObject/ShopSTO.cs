namespace SiCi.Domain;

public class ShopSTO : IBaseServiceTransfereObject
{
	public Guid Id { get; set; }
	public bool Deleted { get; set; }
	public DateTime CreationDate { get; set; }
	public DateTime LastUpdateDate { get; set; }
	public DateTime DeletionDate { get; set; }
	public string Name { get; set; }
}
