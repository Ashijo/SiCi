using SiCi.Contract;
using SiCi.ServiceTransferObject;

namespace SiCi.Core.WebApi.Mappers;

internal static class STOCrossContract
{
	internal static Company ToContract(this CompanySTO sto)
	{
		return new Company
		{
			Id = sto.Id,
			Name = sto.Name,
			Deleted = sto.Deleted,
			CreationDate = sto.CreationDate,
			LastUpdateDate = sto.LastUpdateDate,
			DeletionDate = sto.DeletionDate
		};
	}

	internal static Price ToContract(this PriceSTO sto)
	{
		return new Price
		{
			Id = sto.Id,
			Value = sto.Value,
			Deleted = sto.Deleted,
			CreationDate = sto.CreationDate,
			LastUpdateDate = sto.LastUpdateDate,
			DeletionDate = sto.DeletionDate
		};
	}

	internal static Product ToContract(this ProductSTO sto)
	{
		return new Product
		{
			Id = sto.Id,
			Name = sto.Name,
			Deleted = sto.Deleted,
			CreationDate = sto.CreationDate,
			LastUpdateDate = sto.LastUpdateDate,
			DeletionDate = sto.DeletionDate
		};
	}

	internal static Shop ToContract(this ShopSTO sto)
	{
		return new Shop
		{
			Id = sto.Id,
			Name = sto.Name,
			Deleted = sto.Deleted,
			CreationDate = sto.CreationDate,
			LastUpdateDate = sto.LastUpdateDate,
			DeletionDate = sto.DeletionDate
		};
	}

	internal static CompanySTO ToSTO(this Company contract)
	{
		return new CompanySTO
		{
			Id = contract.Id,
			Name = contract.Name,
			Deleted = contract.Deleted,
			CreationDate = contract.CreationDate,
			LastUpdateDate = contract.LastUpdateDate,
			DeletionDate = contract.DeletionDate
		};
	}

	internal static PriceSTO ToSTO(this Price contract)
	{
		return new PriceSTO
		{
			Id = contract.Id,
			Value = contract.Value,
			Deleted = contract.Deleted,
			CreationDate = contract.CreationDate,
			LastUpdateDate = contract.LastUpdateDate,
			DeletionDate = contract.DeletionDate
		};
	}

	internal static ProductSTO ToSTO(this Product contract)
	{
		return new ProductSTO
		{
			Id = contract.Id,
			Name = contract.Name,
			Deleted = contract.Deleted,
			CreationDate = contract.CreationDate,
			LastUpdateDate = contract.LastUpdateDate,
			DeletionDate = contract.DeletionDate
		};
	}

	internal static ShopSTO ToSTO(this Shop contract)
	{
		return new ShopSTO
		{
			Id = contract.Id,
			Name = contract.Name,
			Deleted = contract.Deleted,
			CreationDate = contract.CreationDate,
			LastUpdateDate = contract.LastUpdateDate,
			DeletionDate = contract.DeletionDate
		};
	}
}
