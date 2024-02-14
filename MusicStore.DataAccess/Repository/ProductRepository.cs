using MusicStore.DataAccess.Data;
using MusicStore.DataAccess.Repository.IRepository;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
           var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if(objFromDb != null)
            {
                objFromDb.SongName = obj.SongName;
                objFromDb.Artist = obj.Artist;
                objFromDb.Album = obj.Album;
                //objFromDb.Genre = obj.Genre;
                objFromDb.Price = obj.Price;
                if(obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
