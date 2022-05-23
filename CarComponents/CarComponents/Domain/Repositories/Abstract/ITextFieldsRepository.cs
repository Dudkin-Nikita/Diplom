using CarComponents.Domain.Entities;

namespace CarComponents.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeword(string codeword);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
