using System.Collections.Generic;
using WebStore1.Domain.Model.Base;

namespace WebStore1.Models
{
    public class SectionViewModel : NamedEntity, IOrderedEntity
    {
        public SectionViewModel()
        {
            ChildSections = new List<SectionViewModel>();
        }

        /// <summary>
        /// Дочерние секции
        /// </summary>
        public List<SectionViewModel> ChildSections { get; set; }

        /// <summary>
        /// Родительская секция
        /// </summary>
        public SectionViewModel ParentSection { get; set; }

        public int Order { get; set; }
    }
}
