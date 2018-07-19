using WebStore1.Domain.Model.Base;

namespace WebStore1.Domain.Model
{
    public class Section : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int? ParentId { get; set; }
    }
}
