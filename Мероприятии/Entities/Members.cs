namespace Мероприятии.Entities
{
    public class Members
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Tickets> Tickets { get; set; }
        public List<Events> Events { get; set; }


    }
}
