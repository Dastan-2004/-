namespace Мероприятии.Entities
{
    public class Providers
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string NameEvents { get; set; }
        public int BudgetsID { get; set; }
        public Budgets Budgets { get; set; }
        public List<Events> Events { get; set; }
    }
}
