namespace FactsbeeMAUI.Models
{
    public class FactModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string  CategoryImage { get; set; }
        public string Fact { get; set; }

        public FactModel(int id, string categoryName, string _, string fact, string categoryImage)
        {
            Id = id;
            CategoryName = categoryName;
            CategoryImage = categoryImage;
            Fact = fact;
        }
    }
}
