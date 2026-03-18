using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models {

   /// <summary>
   /// objetos a serem vendidos na loja
   /// </summary>
   public class Photography {

      /// <summary>
      /// PK
      /// </summary>
      [Key]
      public int Id { get; set; }

      /// <summary>
      /// nome associado à fotografia
      /// </summary>
      [StringLength(50)]
      [Display(Name ="Título")]
      [Required(ErrorMessage ="{0} é de preenchimento obrigatório")]
      public string Title { get; set; } = string.Empty;

      /// <summary>
      /// descrição (opcional) da fotografia
      /// </summary>
      [StringLength(300)]
      [Display(Name ="Descrição")]
      public string? Description { get; set; }

      /// <summary>
      /// nome do ficheiro que contém a fotografia
      /// </summary>
      public string File { get; set; } = ""; // <=> string.Empty;

      /// <summary>
      /// Data em que a fotografia foi tirada
      /// </summary>
      [Display(Name ="Data")]
      [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
      [DataType(DataType.Date)]
      [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
      public DateTime Date { get; set; }

      /// <summary>
      /// Preço de venda da fotografia
      /// </summary>
      [Display(Name ="Preço")]
      public decimal Price { get; set; }

      /* ******************************************
       * Relacionamentos 1-N
       * ****************************************** */
      /// <summary>
      /// FK para a Categoria da fotografia
      /// </summary>
      [ForeignKey(nameof(Category))]
      [Display(Name ="Categoria")]
      public int CategoryFK { get; set; }
      /// <summary>
      /// FK para a Categoria da fotografia
      /// </summary>
      [ValidateNever]
      [Display(Name = "Categoria")]
      public Category Category { get; set; } = null!;
      /* ****************************************** */



      /* ******************************************
      * Relacionamentos M-N
      * ****************************************** */
      /// <summary>
      /// Lista de compras associadas à fotografia
      /// </summary>
      public ICollection<Purchase> ListOfPurchases { get; set; } = [];
      /* ****************************************** */
   }
}
