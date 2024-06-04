using NygarnDemo.Enums;
using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using System.Drawing;

namespace NygarnDemo.Services.ProductServices
{
    public class PatternService : IPatternService
    {
  //      public List<Pattern>? Patterns { get; set; }

  //      public PatternService()
  //      {
  //          Patterns = MockPattern.GetAllPatterns();
  //      }

  //      public List<Pattern> GetPatterns()
  //      {
  //          return Patterns;
  //      }

  //      public IEnumerable<Pattern> CategoryFilter(Category category)
  //      {
  //          List<Pattern> filterCategory = new List<Pattern>();
  //          foreach (var pattern in Patterns)
  //          {
  //              if (pattern.Category == category)
  //              {
  //                  filterCategory.Add(pattern);
  //              }
  //          }

  //          return filterCategory;
  //      }

		//public IEnumerable<Pattern> FitsFilter(Fits fits)
		//{
		//	List<Pattern> filterFits = new List<Pattern>();
		//	foreach (var pattern in Patterns)
		//	{
		//		if (pattern.Fits == fits)
		//		{
		//			filterFits.Add(pattern);
		//		}
		//	}

		//	return filterFits;
		//}

		//public IEnumerable<Pattern> DiffLevelFilter(string difficultyLevel)
		//{
		//	List<Pattern> filterDiffLevel = new List<Pattern>();
		//	foreach (var pattern in Patterns)
		//	{
		//		if (pattern.DifficultyLevel == difficultyLevel)
		//		{
		//			filterDiffLevel.Add(pattern);
		//		}
		//	}

		//	return filterDiffLevel;
		//}
	}
}
