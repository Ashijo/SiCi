using SiCi.Domain;
using SiCi.RepositoryTransferObject;

namespace SiCi.Core.Service.Mappers;

internal static class RTOCrossModel
{
	internal static CompanyRTO ToRTO(this Company model)
	{
		return new CompanyRTO
		{
			Id = model.Id,
			Name = model.Name,
			Deleted = model.Deleted,
			CreationDate = model.CreationDate,
			LastUpdateDate = model.LastUpdateDate,
			DeletionDate = model.DeletionDate
		};
	}

	internal static PriceRTO ToRTO(this Price model)
	{
		return new PriceRTO
		{
			Id = model.Id,
			Value = model.Value,
			Deleted = model.Deleted,
			CreationDate = model.CreationDate,
			LastUpdateDate = model.LastUpdateDate,
			DeletionDate = model.DeletionDate
		};
	}

	internal static ProductRTO ToRTO(this Product model)
	{
		return new ProductRTO
		{
			Id = model.Id,
			Name = model.Name,
			Deleted = model.Deleted,
			CreationDate = model.CreationDate,
			LastUpdateDate = model.LastUpdateDate,
			DeletionDate = model.DeletionDate
		};
	}

	internal static ShopRTO ToRTO(this Shop model)
	{
		return new ShopRTO
		{
			Id = model.Id,
			Name = model.Name,
			Deleted = model.Deleted,
			CreationDate = model.CreationDate,
			LastUpdateDate = model.LastUpdateDate,
			DeletionDate = model.DeletionDate
		};
	}

	internal static Company ToModel(this CompanyRTO rto)
	{
		return new Company
		{
			Id = rto.Id,
			Name = rto.Name,
			Deleted = rto.Deleted,
			CreationDate = rto.CreationDate,
			LastUpdateDate = rto.LastUpdateDate,
			DeletionDate = rto.DeletionDate
		};
	}

	internal static Price ToModel(this PriceRTO rto)
	{
		return new Price
		{
			Id = rto.Id,
			Value = rto.Value,
			Deleted = rto.Deleted,
			CreationDate = rto.CreationDate,
			LastUpdateDate = rto.LastUpdateDate,
			DeletionDate = rto.DeletionDate
		};
	}

	internal static Product ToModel(this ProductRTO rto)
	{
		return new Product
		{
			Id = rto.Id,
			Name = rto.Name,
			Deleted = rto.Deleted,
			CreationDate = rto.CreationDate,
			LastUpdateDate = rto.LastUpdateDate,
			DeletionDate = rto.DeletionDate
		};
	}

	internal static Shop ToModel(this ShopRTO rto)
	{
		return new Shop
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
