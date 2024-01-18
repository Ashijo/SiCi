using SiCi.Core.Service.ServiceObjects;
using SiCi.Domain;

namespace SiCi.Core.Service.Mappers;

public class RTOCrossSO
{
	public static CompanyRTO SOToRTO(CompanySO so)
	{
		return new CompanyRTO
		{
			Id = so.Id,
			Name = so.Name,
			Deleted = so.Deleted,
			CreationDate = so.CreationDate,
			LastUpdateDate = so.LastUpdateDate,
			DeletionDate = so.DeletionDate
		};
	}

	public static PriceRTO SOToRTO(PriceSO so)
	{
		return new PriceRTO
		{
			Id = so.Id,
			Value = so.Value,
			Deleted = so.Deleted,
			CreationDate = so.CreationDate,
			LastUpdateDate = so.LastUpdateDate,
			DeletionDate = so.DeletionDate
		};
	}

	public static ProductRTO SOToRTO(ProductSO so)
	{
		return new ProductRTO
		{
			Id = so.Id,
			Name = so.Name,
			Deleted = so.Deleted,
			CreationDate = so.CreationDate,
			LastUpdateDate = so.LastUpdateDate,
			DeletionDate = so.DeletionDate
		};
	}

	public static ShopRTO SOToRTO(ShopSO so)
	{
		return new ShopRTO
		{
			Id = so.Id,
			Name = so.Name,
			Deleted = so.Deleted,
			CreationDate = so.CreationDate,
			LastUpdateDate = so.LastUpdateDate,
			DeletionDate = so.DeletionDate
		};
	}

	public static CompanySO RTOToSO(CompanyRTO rto)
	{
		return new CompanySO
		{
			Id = rto.Id,
			Name = rto.Name,
			Deleted = rto.Deleted,
			CreationDate = rto.CreationDate,
			LastUpdateDate = rto.LastUpdateDate,
			DeletionDate = rto.DeletionDate
		};
	}

	public static PriceSO RTOToSO(PriceRTO rto)
	{
		return new PriceSO
		{
			Id = rto.Id,
			Value = rto.Value,
			Deleted = rto.Deleted,
			CreationDate = rto.CreationDate,
			LastUpdateDate = rto.LastUpdateDate,
			DeletionDate = rto.DeletionDate
		};
	}

	public static ProductSO RTOToSO(ProductRTO rto)
	{
		return new ProductSO
		{
			Id = rto.Id,
			Name = rto.Name,
			Deleted = rto.Deleted,
			CreationDate = rto.CreationDate,
			LastUpdateDate = rto.LastUpdateDate,
			DeletionDate = rto.DeletionDate
		};
	}

	public static ShopSO RTOToSO(ShopRTO rto)
	{
		return new ShopSO
		{
			Id = rto.Id,
			Name = rto.Name,
			Deleted = rto.Deleted,
			CreationDate = rto.CreationDate,
			LastUpdateDate = rto.LastUpdateDate,
			DeletionDate = rto.DeletionDate
		};
	}
}
