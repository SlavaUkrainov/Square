using System.Linq.Expressions;
using Data.Context;
using Domain.Entities;
using Domain.Repository;

namespace Data.Repository;

public class Repository : IRepository<Square>
{
    private readonly ContextFactory contextFactory;

    public Repository(ContextFactory contextFactory)
    {
        this.contextFactory = contextFactory;
    }

    public Square FirstOrDefault(Expression<Func<Square, bool>> predicate)
    {
        var context = contextFactory.Create();
        return context.Set<Square>().FirstOrDefault(predicate);
    }

    public void Write(Square entity)
    {
        var context = contextFactory.Create();
        context.Set<Square>().Add(entity);
    }
}