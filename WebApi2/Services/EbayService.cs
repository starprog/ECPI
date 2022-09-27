using System.Net.Http.Headers;
using WebApi2.Model.Danual;
using System.Linq;
namespace WebApi2.Services
{
    public class EbayService
    {
        static List<Product> _products;
        public void List(Product product)
        {
            _products.Where(p => p.Price > 2).FirstOrDefault();



        }
    }
}
