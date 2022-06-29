namespace LostAnimal.Orm.Entities
{
    /// <summary>
    /// Add about pet loss
    /// </summary>
    public class AdEntity
    {
        /// <summary>
        /// Gets or sets pet's owner.
        /// </summary>
        public UserEntity Author { get; set; }

        /// <summary>
        /// Gets or sets lost pet.
        /// </summary>
        public PetEntity Pet { get; set; }

        /// <summary>
        /// Gets or sets loss address.
        /// </summary>
        public LossLocationEntity LossAddress { get; set; }
    }
}
