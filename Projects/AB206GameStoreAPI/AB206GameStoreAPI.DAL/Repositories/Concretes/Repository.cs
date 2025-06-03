using AB206GameStoreAPI.DAL.Contexts;
using AB206GameStoreAPI.DAL.Entities;
using AB206GameStoreAPI.DAL.Repositories.Interfaces;

namespace AB206GameStoreAPI.DAL.Repositories.Concretes;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public void Create(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public void Save()
    {
        _context.SaveChanges();
    }


    public IQueryable<T> GetAll()
    {
        IQueryable<T> listT = _context.Set<T>().AsQueryable();
        return listT;
    }

    public T? GetById(int id)
    {
        T? entity = _context.Set<T>().Find(id);
        return entity;
    }

}


