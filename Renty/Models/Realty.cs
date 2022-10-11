namespace Renty.Models
{
    public abstract class Realty
    {
        public int Id { get; set; }
        public double Square { get; set; }
        public int Rooms { get; set; }
        public string Adress { get; set; }
    }
}