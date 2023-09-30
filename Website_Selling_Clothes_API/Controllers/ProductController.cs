using Microsoft.AspNetCore.Mvc;
using APP_DATA.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Website_Selling_Clothes_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public WebsiteSellingClothes _context = new WebsiteSellingClothes();
        // GET: api/<ProductController>
        [HttpGet("get-all-products")]
        public IEnumerable<Product> Get()
        {
            return _context.products.ToList();
        }

        // GET api/<ProductController>/5
        [HttpGet("get-sanphams-{id}")]
        public Product GetProductById(Guid id)
        {
            return _context.products.Find(id);
        }

        // POST api/<ProductController>
        [HttpPost("post-product")]
        public bool PostProduct([FromBody] Guid id, string name,
            string quanlity, string description, double price, int status, DateTime dateproduct)
        {
            try
            {
                id = new Guid();
                Product product = new Product
                {
                    Name = name,
                    Quanlity = quanlity,
                    Description = description,
                    Price = price,
                    Status = status,
                    DateProduct = dateproduct,
                };
                _context.products.Add(product);
                _context.SaveChanges();
                return true;

            }
            catch (global::System.Exception)
            {

                return false;
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("put-product")]
        public bool PutProduct([FromBody] Product product)
        {
            Product productfrDb = _context.products.Find(product.Id);
            try
            {
                productfrDb.Name = product.Name;
                productfrDb.Quanlity = product.Quanlity;
                productfrDb.Description = product.Description;
                productfrDb.Price = product.Price;
                productfrDb.Status = product.Status;
                productfrDb.DateProduct = product.DateProduct;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("delete-product")]
        public bool Delete(Guid id)
        {
            try
            {
                Product product = _context.products.Find(id);
                _context.products.Remove(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
