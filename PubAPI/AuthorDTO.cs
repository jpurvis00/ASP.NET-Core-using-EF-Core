namespace PubAPI
{
    public class AuthorDTO
    {
        /* A DTO is a Data Transfer Object.  It is used to transfer data between software application subsystems.
         * DTOs are often used in conjunction with data access objects to retrieve data from a database.
         * The data is then placed in a DTO and passed to the client tier.  DTOs are simple objects that do not contain
         * any business logic that would require testing.
         * Client <- DTO -> Controller <- Entity -> EF Core
         */

        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
