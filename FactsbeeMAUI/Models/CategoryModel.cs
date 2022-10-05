namespace FactsbeeMAUI.Models
{
    public struct CategoryModel
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public CategoryModel(string name, string image)
        {
            Name = name;
            Image = image;
        }

        public static IEnumerable<CategoryModel> GetCategories()
        {
            return new List<CategoryModel>
            {
                new CategoryModel("Animal", "animal.png"),
                new CategoryModel("Human", "human.png"),
                new CategoryModel("Entertainment", "entertainment.png"),
                new CategoryModel("Science & Technology", "science_technology.png"),
                new CategoryModel("Words & Languagues", "word_language.png"),
                new CategoryModel("Misc", "misc.png"),
            };
        }
    }
}
