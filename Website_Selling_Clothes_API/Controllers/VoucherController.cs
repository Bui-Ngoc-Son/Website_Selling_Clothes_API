using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Website_Selling_Clothes_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        public WebsiteSellingClothes _context = new WebsiteSellingClothes();
        // GET: api/<VoucherController>
        [HttpGet("get-voucher")]
        public IEnumerable<Voucher> Get()
        {
            return _context.vouchers.ToList();
        }

        // GET api/<VoucherController>/5
        [HttpGet("get-voucher-by-name")]
        public IEnumerable<Voucher> GetVoucherByName(string name)
        {
            return _context.vouchers.Where(x => x.Name.Contains(name)).ToList();
        }

        // POST api/<VoucherController>
        [HttpPost("post-voucher")]
        public bool PostVoucher([FromBody] Guid id, string name, string despcription)
        {
            try
            {
                id = new Guid();
                Voucher voucher = new Voucher
                {
                    Name = name,
                    Description = despcription,
                };
                _context.vouchers.Add(voucher);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        // PUT api/<VoucherController>/5
        [HttpPut("put-voucher")]
        public bool PutVoucher([FromBody] Voucher voucher)
        {
            Voucher voucherfrDb = _context.vouchers.Find(voucher.ID);
            try
            {
                voucherfrDb.Name = voucher.Name;
                voucherfrDb.Description = voucher.Description;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        // DELETE api/<VoucherController>/5
        [HttpDelete("delete-voucher")]
        public bool Delete(Guid id)
        {
            try
            {
                Voucher voucher = _context.vouchers.Find(id);
                _context.vouchers.Remove(voucher);
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
