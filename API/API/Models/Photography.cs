using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    /// <summary>
    /// objetos a serem vendidos na loja
    /// </summary>
    public class Photography
    {
        public int Id { get; set; }
        /// <summary>
        /// nome da fotografia
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// descrição da foto
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// ficheiro
        /// </summary>
        public string File {  get; set; }
        /// <summary>
        /// data da compra
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// preço da compra
        /// </summary>
        public decimal Price { get; set; }

        [ForeignKey(nameof(Photography))]
        public int CategoryFK { get; set; }
    }
}
