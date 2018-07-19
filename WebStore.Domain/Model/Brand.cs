using WebStore1.Domain.Model.Base;

namespace WebStore1.Domain.Model
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
