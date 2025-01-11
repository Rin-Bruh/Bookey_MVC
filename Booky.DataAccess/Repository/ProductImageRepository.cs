using Booky.DataAccess.Data;
using Booky.DataAccess.Repository.IRepository;
using Booky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booky.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
	{
        private ApplicationDbContext _db;
        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
