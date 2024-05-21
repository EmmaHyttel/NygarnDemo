using NygarnDemo.Models;
using NygarnDemo.Services.DbServices;

namespace NygarnDemo.Services.UserService
{
    public class WishListService : IWishListService
    {
        public WishListDbService _dbService; 
        private List<Product> Products { get; set; }

        public WishListService(WishListDbService dbService)
        {
            //WishList = GetAllProducts();
            _dbService = dbService;
            //Products = _dbService.GetWishList().Result.ToList(); 
            //_dbService.SaveProduct(Products);
        }

        //public List<Product> GetWishLists()
        //{
        //    return WishList;
        //}

        public List<Product> GetWishList()
        {
            throw new NotImplementedException();
        }


        public WishList GetUserByUserName(string str)
        {
            throw new NotImplementedException();
        }

        public Task AddProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}