﻿using NygarnDemo.Enums;
using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.DbServices;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Services.ProductServices
{
    public class ToolService : IToolService
    {
        private readonly ToolDbService _dbService;
        public List<Tool> ToolProducts { get; set; }

        public ToolService(ToolDbService dbService)
        {
            //ToolProducts = MockTool.GetAllToolProducts();
            _dbService = dbService;
            ToolProducts = _dbService.GetTools().Result.ToList();
            //_dbService.SaveTools(ToolProducts);
        }

        public async Task<List<Tool>> GetToolProducts()
        {
            return await _dbService.GetTools();
        }

        public IEnumerable<Tool> PriceFilter(int maxPrice, int minPrice = 0)
        {
            List<Tool> filterList = new List<Tool>();
            foreach (Tool priceFilter in ToolProducts)
            {
                if ((minPrice == 0 && priceFilter.Price <= maxPrice) || (maxPrice == 0 && priceFilter.Price >= minPrice) || (priceFilter.Price >= minPrice && priceFilter.Price <= maxPrice))
                {
                    filterList.Add(priceFilter);
                }
            }
            return filterList;
        }
        public IEnumerable<Tool> SizeFilter(string str)
        {
            List<Tool> sizeFilter = new List<Tool>();
            foreach (Tool tool in ToolProducts)
            {
                if (string.IsNullOrEmpty(str) || tool.Name.ToLower().Contains(str.ToLower()))
                {
                    sizeFilter.Add(tool);
                }
            }
            return sizeFilter;
        }

        public IEnumerable<Tool> BrandFilter(string str)
        {
            List<Tool> brandFilter = new List<Tool>();
            foreach (Tool tool in ToolProducts)
            {
                if (string.IsNullOrEmpty(str) || tool.Name.ToLower().Contains(str.ToLower()))
                {
                    brandFilter.Add(tool);
                }
            }
            return brandFilter;
        }

        public IEnumerable<Tool> NameSearch(string str)
        {
            List<Tool> nameSearch = new List<Tool>();
            foreach (Tool tool in ToolProducts)
            {
                if (string.IsNullOrEmpty(str) || tool.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(tool);
                }
            }
            return nameSearch;
        }

        public IEnumerable<Tool> TypeSearch(string type)
        {
            List<Tool> typeFilter = new List<Tool>();
            foreach (Tool tool in ToolProducts)
            {
                if (string.IsNullOrEmpty(type) || tool.Name.ToLower().Contains(type.ToLower()))
                {
                    typeFilter.Add(tool);
                }
            }
            return typeFilter;
        }

        public async Task AddToolAsync(Tool tool)
        {
            await _dbService.AddTool(tool);
        }

        public async Task<Tool> GetTool(int id)
        {
            foreach (Tool tool in ToolProducts)
            {
                if (tool.ProductId == id)
                    return tool;
            }

            return null;
        }

        //public async Task<Tool> DeleteToolAsync(Tool tool)
        //{
        //    //Tool ToolToBeDeleted = null;
        //    foreach (Tool t in ToolProducts)
        //    {
        //        if (t == tool)
        //        {
        //            await _dbService.DeleteToolAsync(tool);
        //            break;
        //        }
        //    }
        //    //if (ToolToBeDeleted != null)
        //    //{
        //    //    //ToolProducts.Remove(ToolToBeDeleted);
        //    //    await _dbService.DeleteToolAsync(ToolToBeDeleted);
        //    //}

        //    return tool;
        //}

        public async Task UpdateToolAsync(Tool tool)
        {
            if (tool != null)
            {
                foreach (Tool t in ToolProducts)
                {
                    if (t.ProductId == tool.ProductId)
                    {
                        t.Name = tool.Name;
                        t.Price = tool.Price;
                        t.Description = tool.Description;

                    }

                }
				await _dbService.UpdateTool(tool);
				//await _dbService.SaveTools(ToolProducts);
			}
        }

        public async Task<Tool> DeleteToolAsync(int? productId)
        {
            Tool toolToBeDeleted = null;
            foreach (Tool tool in ToolProducts)
            {
                if (tool.ProductId == productId)
                {
                    toolToBeDeleted = tool;
                    break;
                }
            }

            if (toolToBeDeleted != null)
            {
                //ToolProducts.Remove(toolToBeDeleted);
                await _dbService.DeleteTool(toolToBeDeleted);
            }

            return toolToBeDeleted;
        }
    }
}
