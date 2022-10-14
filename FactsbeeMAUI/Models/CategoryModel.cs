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
                new CategoryModel("Word & Language", "word_language.png"),
                new CategoryModel("Misc", "misc.png"),
            };
        }

        public static IReadOnlyDictionary<string, string> CategoryImagesMap =>
            new Dictionary<string, string>
            {
                ["Animal"] = "animal.png",
                ["Human"] = "human.png",
                ["Entertainment"] = "entertainment.png",
                ["Science & Technology"] = "science_technology.png",
                ["Word & Language"] = "word_language.png",
                ["Misc"] = "misc.png",
            };
    }
}
