
using System.Reflection.Metadata;

namespace Domain
{
    public class Activity
    {
        // EntityHandle framework needs all of the properties 
        // to be public so it can access them

        //ENtity framework references the Id property to be the primary key
        // It shoud be a Guid type and named Id Exactly
        //or give it an attribute of [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}