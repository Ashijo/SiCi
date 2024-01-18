using SiCi.Core.Service.ServiceObjects;
using SiCi.ServiceTransferObject;

namespace SiCi.Core.Service.Mappers;

internal static class STOCrossSO
{
	internal static CompanySTO ToSTO(this CompanySO so)
	{
		return new CompanySTO
		{
			Id = so.Id,
			Name = so.Name,
			Deleted = so.Deleted,
			CreationDate = so.CreationDate,
			LastUpdateDate = so.LastUpdateDate,
			DeletionDate = so.DeletionDate
		};
	}

	internal static PriceSTO ToSTO(this PriceSO so)
	{
		return new PriceSTO
		{
			Id = so.Id,
			Value = so.Value,
			Deleted = so.Deleted,
			CreationDate = so.CreationDate,
			LastUpdateDate = so.LastUpdateDate,
			DeletionDate = so.DeletionDate
		};
	}

	internal static ProductSTO ToSTO(this ProductSO so)
	{
		return new ProductSTO
		{
			Id = so.Id,
			Name = so.Name,
			Deleted = so.Deleted,
			CreationDate = so.CreationDate,
			LastUpdateDate = so.LastUpdateDate,
			DeletionDate = so.DeletionDate
		};
	}

	internal static ShopSTO ToSTO(this ShopSO so)
	{
		return new ShopSTO
		{
			Id = so.Id,
			Name = so.Name,
			Deleted = so.Deleted,
			CreationDate = so.CreationDate,
			LastUpdateDate = so.LastUpdateDate,
			DeletionDate = so.DeletionDate
		};
	}

	internal static CompanySO ToSO(this CompanySTO sto)
	{
		return new CompanySO
		{
			Id = sto.Id,
			Name = sto.Name,
			Deleted = sto.Deleted,
			CreationDate = sto.CreationDate,
			LastUpdateDate = sto.LastUpdateDate,
			DeletionDate = sto.DeletionDate
		};
	}

	internal static PriceSO ToSO(this PriceSTO sto)
	{
		return new PriceSO
		{
			Id = sto.Id,
			Value = sto.Value,
			Deleted = sto.Deleted,
			CreationDate = sto.CreationDate,
			LastUpdateDate = sto.LastUpdateDate,
			DeletionDate = sto.DeletionDate
		};
	}

	internal static ProductSO ToSO(this ProductSTO sto)
	{
		return new ProductSO
		{
			Id = sto.Id,
			Name = sto.Name,
			Deleted = sto.Deleted,
			CreationDate = sto.CreationDate,
			LastUpdateDate = sto.LastUpdateDate,
			DeletionDate = sto.DeletionDate
		};
	}

	internal static ShopSO ToSO(this ShopSTO sto)
	{
		return new ShopSO
		{
			Id = sto.Id,
			Name = sto.Name,
			Deleted = sto.Deleted,
			CreationDate = sto.CreationDate,
			LastUpdateDate = sto.LastUpdateDate,
			DeletionDate = sto.DeletionDate
		};
	}
}
