namespace AB206GameStoreAPI.DAL.Repositories.Interfaces;

public interface IRepository<T>
{

    //DML
    void Create(T entity);

    void Update(T entity);
    void Delete(T entity);

    void Save();


    //DQL
    IQueryable<T> GetAll();

    T? GetById(int id);
}


