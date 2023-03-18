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
        public List<Members> Members { get; set; }
        public int ProvidersID { get; set; }
        public List<Providers> Providers { get; set; }
        public int TicketsID { get; set; }
        public List<Tickets> Tickets { get; set; }

    }
}
