using CarComponents.Domain.Repositories.Abstract;

namespace CarComponents.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        //public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository)
        {
            TextFields = textFieldsRepository;
            //ServiceItems = serviceItemsRepository;
        }

    }
}
