namespace LostAnimal.Orm.Entities
{
    /// <summary>
    /// Pet.
    /// </summary>
    public class PetEntity
    {
        /// <summary>
        /// Gets or sets pet's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets pet's photo path.
        /// </summary>
        public string PhotoPath { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets pets owner.
        /// </summary>
        public UserEntity Owner { get; set; }

        /// <summary>
        /// Gets or sets pet status.
        /// </summary>
        public PetStatusEntity PetStatusEntity { get; set; }
    }
}
