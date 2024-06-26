﻿using NygarnDemo.Enums;
using NygarnDemo.Models;
using NygarnDemo.Services.ProductServices;

namespace NygarnDemo.Services.Interfaces
{
    public interface IToolService
    {
        Task<List<Tool>> GetToolProducts();
        Task<Tool> DeleteToolAsync(int? productId);
        Task AddToolAsync(Tool tool);
        Task<Tool> GetTool(int id);
        Task UpdateToolAsync(Tool tool);
        IEnumerable<Tool> PriceFilter(int maxPrice, int minPrice = 0);
        IEnumerable<Tool> SizeFilter(string str);
        IEnumerable<Tool> BrandFilter(string brand);
        IEnumerable<Tool>  NameSearch(string str);
        IEnumerable<Tool> TypeSearch(string type);

        

    }
}
