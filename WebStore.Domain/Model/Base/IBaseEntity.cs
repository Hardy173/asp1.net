namespace WebStore1.Domain.Model.Base
{
    /// <summary>
    /// Base entity with Id
    /// </summary>
    public interface IBaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        int Id { get; set; }

    }
}
