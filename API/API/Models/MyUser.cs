namespace API.Models
{
    public class MyUser
    {
        public int Id { get; set; }
        /// <summary>
        /// nome do utilizador
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// morada do utilizador
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// código postal do utilizador
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// país
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// numero de contribuinte
        /// </summary>
        public string TaxNumber { get; set; }
        /// <summary>
        /// numero de telemovel
        /// </summary>
        public string CellPhone { get; set; }
        public ICollection<Purchase> ListOfPurchase { get; set; }
    }
}
