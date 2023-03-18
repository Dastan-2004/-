namespace Мероприятии.Entities
{
     public class Events
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int MembersID { get; set; }
        public Members Members { get; set; }
        public int ProvidersID { get; set; }
        public Providers Providers { get; set; }

    }
}
