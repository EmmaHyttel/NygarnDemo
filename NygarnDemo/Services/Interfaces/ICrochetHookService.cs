﻿using NygarnDemo.Enums;
using NygarnDemo.Models;
using System.Drawing;
using Size = NygarnDemo.Enums.Size;


namespace NygarnDemo.Services.Interfaces
{
    public interface ICrochetHookService
    {
        List<CrochetHook> GetCrochetHooks();



		Task AddCrochetHookAsync(CrochetHook crochetHook);

		IEnumerable<CrochetHook> HooksPriceFilter (int maxPrice, int minPrice = 0);
        
        IEnumerable<CrochetHook> NameSearch(string str);
        
        IEnumerable<CrochetHook> CrochetHooksSizeFilter(Size size);
        
        IEnumerable<CrochetHook> HooksMaterialFilter(NeedleAndHookMaterial material);

        Task<CrochetHook> DeleteHookAsync(int? Id);
    }
}
