namespace API.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } 
        public State State { get; set; }
        public ICollection<Photography> ListOfPhotos { get; set; }
    }
}
