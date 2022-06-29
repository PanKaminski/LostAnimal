namespace LostAnimal.Orm.Entities
{
    /// <summary>
    /// Pet's owner.
    /// </summary>
    public class UserEntity
    {
        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets user's phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets photo path.
        /// </summary>
        public string PhotoPath { get; set; }

        /// <summary>
        /// Gets or sets user help rating.
        /// </summary>
        public float Rating { get; set; }

        /// <summary>
        /// Gets or sets count of help messages.
        /// </summary>
        public int HelpsCount { get; set; }

        /// <summary>
        /// Gets or sets count of helps.
        /// </summary>
        public int ThanksCount { get; set; }

        /// <summary>
        /// Gets or sets user's pets.
        /// </summary>
        public IEnumerable<PetEntity> Pets { get; set; }
    }
}
