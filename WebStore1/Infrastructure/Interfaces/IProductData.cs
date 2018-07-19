using System.Collections.Generic;
using WebStore1.Domain.Model;
using WebStore1.Models;

namespace WebStore1.Infrastructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();

        IEnumerable<Brand> GetBrands();

        /// <summary>
        /// Список товаров
        /// </summary>
        /// <param name="filter">Фильтр товаров</param>
        /// <returns></returns>
        IEnumerable<Product> GetProducts(ProductFilter filter);
    }
}
