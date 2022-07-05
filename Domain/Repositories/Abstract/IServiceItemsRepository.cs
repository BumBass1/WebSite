using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSite11.Domain.Entities;


namespace WebSite11.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository // услуги
    {
        IQueryable<ServiceItem> GetServiceItems(); // выборка услуг
        ServiceItem GetServiceItemById(Guid id); // выборка услуг по Id
        void SaveServiceItem(ServiceItem entity); // сохранить услуги
        void DeleteServiceItem(Guid id); // удалить услуги
    }
}
