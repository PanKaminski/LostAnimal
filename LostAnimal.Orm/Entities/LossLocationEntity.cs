namespace LostAnimal.Orm.Entities
{
    /// <summary>
    /// Lost pet area location.
    /// </summary>
    public class LossLocationEntity
    {
        /// <summary>
        /// Gets or sets address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets exact coordinates.
        /// </summary>
        public string Coordinates { get; set; }
    }
}
