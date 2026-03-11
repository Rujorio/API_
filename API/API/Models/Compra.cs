using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Compra
    {
        public int Id { get; set; }
        /// <summary>
        /// data da compra
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// estado da compr
        /// </summary>
        public State State { get; set; }
        public MyUser Buyer { get; set; }
        [ForeignKey(nameof(Buyer))]
        public int BuyerFK { get; set; }

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
