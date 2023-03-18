namespace Мероприятии.Entities
{
    public class Tickets
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int MembersID { get; set; }
        public Members Members { get; set; }
    }
}
