using Mono.TextTemplating;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models {

   /// <summary>
   /// dados da compra de fotografias, por um utilizador
   /// </summary>
   public class Purchase {

      /// <summary>
      /// PK
      /// </summary>
      [Key]
      public int Id { get; set; }

      /// <summary>
      /// Data da compra
      /// </summary>
      public DateTime Date { get; set; }

      /// <summary>
      /// Estado (situação) em que se encontra a compra
      /// </summary>
      public State State { get; set; }

      /* ******************************************
       * Relacionamentos 1-N
       * ****************************************** */

      /// <summary>
      /// FK para a tabela dos clientes
      /// </summary>
      [ForeignKey(nameof(Buyer))]
      public int BuyerFK { get; set; }
      /// <summary>
      /// cliente que efetuou a Compra
      /// </summary>
      public MyUser Buyer { get; set; }
      /* ****************************************** */


      /* ******************************************
      * Relacionamentos M-N
      * ****************************************** */
      /// <summary>
      /// Lista de fotografias associadas à compra
      /// </summary>
      public ICollection<Photography> ListOfPhotos { get; set; }
      /* ****************************************** */

   }

   /// <summary>
   /// Possíveis estados associados a uma compra
   /// </summary>
   public enum State {
      Pending,
      Paid,
      Sent,
      Delivered,
      Closed
   }





}
