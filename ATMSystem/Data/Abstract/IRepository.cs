

using System.Linq.Expressions;

namespace ATMSystem.Data.Abstract
{
    public interface IRepository<T>
    {
        List<T>? GetAll();
        List<T>? GetAllExpression(Expression<Func<T, bool>> filter = null!);
        T? Find(Expression<Func<T, bool>> filter);
    }
}