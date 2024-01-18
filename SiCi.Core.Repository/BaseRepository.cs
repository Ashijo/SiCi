using SiCi.Domain;

namespace SiCi.Repository;

public class BaseRepository<T> where T : IBaseModel
{
	private List<T> Models { get; set; } = new();

	public T? Get(Guid Id)
	{
		return Models.Find(o => o.Id == Id);
	}

	public T[] GetAll()
	{
		return Models.ToArray();
	}

	public T Add(T model)
	{
		model.Id = new Guid();
		model.CreationDate = new DateTime();
		Models.Add(model);
		return model;
	}

	public T Update(T model)
	{
		var index = Models.FindIndex(m => m.Id == model.Id);
		if (index == -1)
		{
			throw new InvalidOperationException("Object not found in repository");
		}

		model.LastUpdateDate = DateTime.Now;
		Models[index] = model;
		return Models[index];
	}

	public void Delete(Guid Id)
	{
		var model = Models.Find(m => m.Id == Id);
		if (model == null)
		{
			throw new InvalidOperationException("Object not found in repository");
		}

		model.Deleted = true;
		model.DeletionDate = DateTime.Now;
		Update(model);
	}
}
