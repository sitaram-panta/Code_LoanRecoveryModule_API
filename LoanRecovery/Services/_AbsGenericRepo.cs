using System;
using System.Linq;
using System.Threading.Tasks;
using LoanRecovery.Data;
using LoanRecovery.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LoanRecovery.Services
{
    public class _AbsGenericRepo<MainEntity, PKType> : _IAbsGenericRepo<MainEntity, PKType>
        where MainEntity : class
    {
        private readonly AppDbContext context;

        public _AbsGenericRepo(AppDbContext _context)
        {
            context = _context ?? throw new ArgumentNullException(nameof(_context));
        }

        public virtual IQueryable<MainEntity> GetList()
        {
            var result = context.Set<MainEntity>().AsQueryable();
            if ( !result.Any())
            {
                throw new InvalidOperationException("The result of GetList is null.");
            }
            return result;
        }

        public virtual async Task<MainEntity> GetDetails(PKType id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id), "ID cannot be null.");
            }

            var entity = await context.Set<MainEntity>().FindAsync(id);

            if (entity == null)
            {
                throw new InvalidOperationException($"Entity with ID {id} not found.");
            }

            return entity;
        }

        public virtual async Task<MainEntity> Create(MainEntity table)
        {
            if (table == null)
            {
                throw new ArgumentNullException(nameof(table), "Entity cannot be null.");
            }

            context.Set<MainEntity>().Add(table);
            await context.SaveChangesAsync();
            return table;
        }

        public virtual async Task<MainEntity> Update(PKType id, MainEntity table)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id), "ID cannot be null.");
            }

            if (table == null)
            {
                throw new ArgumentNullException(nameof(table), "Entity cannot be null.");
            }

            var existingEntity = await context.Set<MainEntity>().FindAsync(id);

            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Entity with ID {id} not found.");
            }

            context.Entry(existingEntity).CurrentValues.SetValues(table);
            await context.SaveChangesAsync();
            return existingEntity;
        }

        public virtual async Task<MainEntity> Delete(PKType id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id), "ID cannot be null.");
            }

            var entity = await context.Set<MainEntity>().FindAsync(id);

            if (entity == null)
            {
                throw new InvalidOperationException($"Entity with ID {id} not found.");
            }

            context.Set<MainEntity>().Remove(entity);
            await context.SaveChangesAsync();
            return entity;
        }
    }
}
