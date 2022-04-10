using System.Linq.Expressions;

namespace Domain.Repository;

public interface IRepository<TEntity>
{
    public TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

    public void Write(TEntity entity);
}