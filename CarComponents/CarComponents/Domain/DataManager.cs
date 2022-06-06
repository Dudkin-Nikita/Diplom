using CarComponents.Domain.Repositories.Abstract;

namespace CarComponents.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public ICarComponentsRepository CarComponents { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, ICarComponentsRepository carComponentsRepository)
        {
            TextFields = textFieldsRepository;
            CarComponents = carComponentsRepository;
        }

    }
}
