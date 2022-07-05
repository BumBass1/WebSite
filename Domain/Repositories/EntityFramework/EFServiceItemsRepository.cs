using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSite11.Domain.Entities;
using WebSite11.Domain.Repositories.Abstract;

namespace WebSite11.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        public readonly AppDbContext context;
        public EFServiceItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItem;
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItem.FirstOrDefault(x => x.Id == id);

        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State |= EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItem.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }
              
    }
}
