namespace WebStore1.Domain.Model.Base
{
    public interface INamedEntity : IBaseEntity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; set; }

    }
}
