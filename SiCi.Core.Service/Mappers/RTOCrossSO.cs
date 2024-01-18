using SiCi.Core.Service.ServiceObjects;
using SiCi.RepositoryTransferObject;

namespace SiCi.Core.Service.Mappers;

internal static class RTOCrossSO
{
	internal static CompanyRTO ToRTO(this CompanySO so)
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

	internal static PriceRTO ToRTO(this PriceSO so)
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

	internal static ProductRTO ToRTO(this ProductSO so)
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

	internal static ShopRTO ToRTO(this ShopSO so)
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

	internal static CompanySO ToSO(this CompanyRTO rto)
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

	internal static PriceSO ToSO(this PriceRTO rto)
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

	internal static ProductSO ToSO(this ProductRTO rto)
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

	internal static ShopSO ToSO(this ShopRTO rto)
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
