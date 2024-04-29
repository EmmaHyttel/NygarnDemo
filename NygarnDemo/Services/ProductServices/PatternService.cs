﻿using NygarnDemo.Enums;
using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using System.Drawing;

namespace NygarnDemo.Services.ProductServices
{
    public class PatternService : IPatternService
    {
        public List<Pattern>? Patterns { get; set; }

       //public PatternService(IPatternService patternService)
       // {
       //     Patterns = MockPattern.GetAllPatterns();
       // }

        public PatternService()
        {
            Patterns = MockPattern.GetAllPatterns();
        }

        public List<Pattern> GetPatterns()
        {
            return Patterns;
        }

        public IEnumerable<Pattern> CategoryFilter(Category category)
        {
            List<Pattern> filterCategory = new List<Pattern>();
            foreach (var pattern in Patterns)
            {
                if (pattern.Category == category)
                {
                    filterCategory.Add(pattern);
                }
            }

            return filterCategory;
        }
    }
}
