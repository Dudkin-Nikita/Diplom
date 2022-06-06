using CarComponents.Domain.Entities;
using CarComponents.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CarComponents.Domain.Repositories.EntityFramework
{
    public class EFCarComponentsRepository : ICarComponentsRepository
    {
        private readonly AppDbContext context;
        public EFCarComponentsRepository(AppDbContext context)
        {
            this.context = context;
        }  
        public IQueryable<CarComponent> GetCarComponents()
        {
            return context.CarComponents;
        }
        public CarComponent GetCarComponentById(Guid id)
        {
            return context.CarComponents.FirstOrDefault(x => x.Id == id);
        }
        public void SaveCarComponent(CarComponent entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public void DeleteCarComponent(Guid id)
        {
            context.CarComponents.Remove(new CarComponent() { Id = id });
            context.SaveChanges();
        }
    }
}
