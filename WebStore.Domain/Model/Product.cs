using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore1.Domain.Model.Base;

namespace WebStore1.Models
{
    public class Product: NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        /// <summary>
        /// Секция к которой принадлежит товар
        /// </summary>
        public int SectionId { get; set; }

        public object GetProducts(ProductFilter productFilter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Бренд товара
        /// </summary>
        public int? BrandId { get; set; }
        /// <summary>
        /// Ссылка на картинку
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
    }
}
