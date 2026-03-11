namespace API.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public State State { get; set; }
    }
    
    public enum State
    {
        Pending,
        Paid,
        Sent,
        DDelivered,
        Closedd
    }
}
