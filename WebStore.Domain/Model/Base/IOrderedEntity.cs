namespace WebStore1.Domain.Model.Base
{
    public interface IOrderedEntity
    {
        /// <summary>
        /// Порядок
        /// </summary>
        int Order { get; set; }
    }
}
