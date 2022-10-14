namespace FactsbeeMAUI.Models
{
    public class FactModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Fact { get; set; }

        public FactModel(int id, string _, string __, string fact, string categoryName)
        {
            Id = id;
            CategoryName = categoryName;
            Fact = fact;
        }

        public string CategoryImage => CategoryModel.CategoryImagesMap.TryGetValue(CategoryName, out string categoryImage) 
                                        ? categoryImage
                                        : "";
    }
}
