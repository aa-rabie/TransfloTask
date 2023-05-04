namespace Transflo.Driver.Models
{
    public class Driver
    {
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Required
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// Required
        /// </summary>
        public string? LastName { get; set; }
        
        public string? Email { get; set; }
        /// <summary>
        /// Assumption : optional
        /// </summary>
        public string? Phone { get; set; }



        public string? FullName
        {
            get
            {
                if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName))
                    return string.Empty;

                else if (string.IsNullOrEmpty(FirstName))
                    return LastName!.ToLowerInvariant();
                else if (string.IsNullOrEmpty(LastName))
                    return FirstName!.ToLowerInvariant();

                return $"{FirstName} {LastName}".ToLowerInvariant();
            }
        }
    }
}