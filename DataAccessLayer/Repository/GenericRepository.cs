using DataAccessLayer.Abstract;

namespace DataAccessLayer.Repository;

public class GenericRepository<T>:IGenericDal<T> where T :class
{
    public void Insert(T t)
    {
        using var c=new Context();
        c.Add(t);
    }

    public void Delete(T t)
    {
        using var c=new Context();
        c.Remove(t);
        c.SaveChanges();
      
    }

    public void Update(T t)
    {
        using var c=new Context();
        c.Update(t);
    }

    public List<T> GetList()
    {
        using var c=new Context();
        return c.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        using var c=new Context();
        return c.Set<T>().Find(id);
    }
}