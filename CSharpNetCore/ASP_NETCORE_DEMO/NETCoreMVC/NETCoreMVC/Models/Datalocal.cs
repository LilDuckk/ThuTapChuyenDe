namespace NETcoreWebMVC.Models
{
    public class Datalocal
    {
        public static List<Category> _categories = new List<Category>()
        {
            new Category() { Id=1, Name="DevMaster", CreateDate=DateTime.Now, CreateBy="Viet", Status=true },
            new Category() { Id = 2, Name = "DevMaster2", CreateDate = DateTime.Now, CreateBy = "Duc", Status = true },
            new Category() { Id = 3, Name = "DevMaster3", CreateDate = DateTime.Now, CreateBy = "Dung", Status = false }
        };
        public static List<Product> _products = new List<Product>()
        {
            new Product() { Id = 1, Name="hgcjchg", Description="sdsafsafa", Price=10000, SalePrice=1000, Image="", CategoryId=1, CreateDate=DateTime.Now, CreateBy="sad", Status=true },
        };
    }
}
