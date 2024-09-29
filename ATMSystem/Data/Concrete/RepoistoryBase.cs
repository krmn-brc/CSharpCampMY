

using System.Linq.Expressions;
using ATMSystem.Data.Abstract;

namespace ATMSystem.Data.Concrete
{
    public class RepoistoryBase<TEntity>: IRepository<TEntity>
    {
        protected List<TEntity>? Data { get; set; }

        public TEntity? Find(Expression<Func<TEntity, bool>> filter)
        {
            var asQueryData = Data!.AsQueryable();
            return asQueryData.SingleOrDefault(filter);
        }

        public List<TEntity>? GetAll()
        {
            return Data!;
        }

        public List<TEntity>? GetAllExpression(Expression<Func<TEntity, bool>> filter = null!)
        {
            var asQueryData = Data!.AsQueryable();
            return filter == null ? asQueryData.ToList() : asQueryData.Where(filter).ToList(); 
        }
    }
}