using SiCi.Domain;

namespace SiCi.Repository;

public class BaseRepository<T> where T : IBaseModel
{
	private List<T> Models { get; } = new();

	protected T? GetById(Guid id)
	{
		return Models.Find(o => o.Id == id);
	}

	protected T[] GetAllNotDeleted()
	{
		return Models.ToArray();
	}

	protected T Add(T model)
	{
		model.Id = Guid.NewGuid();
		model.CreationDate = DateTime.UtcNow;
		Models.Add(model);
		return model;
	}

	protected T Update(T model)
	{
		var index = Models.FindIndex(m => m.Id == model.Id);
		if (index == -1)
		{
			throw new InvalidOperationException("Object not found in repository");
		}

		model.LastUpdateDate = DateTime.UtcNow;
		Models[index] = model;
		return Models[index];
	}

	protected void SoftDelete(Guid id)
	{
		var model = Models.Find(m => m.Id == id);
		if (model == null)
		{
			throw new InvalidOperationException("Object not found in repository");
		}

		model.Deleted = true;
		model.DeletionDate = DateTime.Now;
		Update(model);
	}
}
