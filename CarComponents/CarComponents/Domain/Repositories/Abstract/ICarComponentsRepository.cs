using CarComponents.Domain.Entities;

namespace CarComponents.Domain.Repositories.Abstract
{
    public interface ICarComponentsRepository
    {
        IQueryable<CarComponent> GetCarComponents();
        CarComponent GetCarComponentById(Guid id);
        void SaveCarComponent(CarComponent entity);
        void DeleteCarComponent(Guid id);
    }
}
