using System.Dynamic;

namespace WebApi2.Model.Danual
{
    public class Product
    {
        private string _privatefield;
        protected string _protectedField;
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        ExpandoObject test = new ExpandoObject();



    }
}