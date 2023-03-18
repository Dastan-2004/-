namespace Мероприятии.Entities
{
    public class Budgets
    {
        public int ID { get; set; }
        public int Summa { get; set; }
        public List<Providers> Providers { get; set; }
    }
}
