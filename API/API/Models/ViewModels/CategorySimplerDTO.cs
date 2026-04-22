namespace API.Models.ViewModels {

   /// <summary>
   /// classe utilizada para apresentar uma Categoria simples,
   /// ou adicionar uma nova
   /// </summary>
   public class CategorySimplerDTO {

      /// <summary>
      /// the 'name' of the Category
      /// </summary>
      public string Name { get; set; } = ""; // <=> string.Empty;

   }
}
