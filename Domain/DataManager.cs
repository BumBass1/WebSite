using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite11.Domain.Repositories.Abstract;

namespace WebSite11.Domain
{
    public class DataManager
    {
        // централизованный класс для управлением репозиториями
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
