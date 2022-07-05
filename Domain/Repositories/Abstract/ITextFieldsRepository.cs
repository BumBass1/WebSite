using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSite11.Domain.Entities;

namespace WebSite11.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields(); // выборка всех текстовых полей 
        TextField GetTextFieldById(Guid id); // выборка по Id
        TextField GetTextFieldByCodeWord(string codeWord); // выборка по кодовому слову
        void SaveTextField(TextField entity); // сохранить изменения
        void DeleteTextField(Guid id); // удаление текстового поля
    }
}
