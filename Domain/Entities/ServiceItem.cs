using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebSite11.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название услуг")]
        [Display(Name = "Название услуг")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание услуги")]
        public override string Text { get; set; }

    }
}
