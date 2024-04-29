using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Enums;

public enum DifficultyLevel
{
	[Display(Name = "1 ud af 5")]
	DiffLevel1of5 = 1,
	[Display(Name = "2 ud af 5")]
	DiffLevel2of5 = 2,
	[Display(Name = "3 ud af 5")]
	DiffLevel3of5 = 3,
	[Display(Name = "4 ud af 5")]
	DiffLevel4of5 = 4,
	[Display(Name = "5 ud af 5")]
	DiffLevel5of5 = 5,
	[Display(Name = "* Nybegynder")]
	Nybegynder = 6,
	[Display(Name = "** Enkel")]
	Enkel = 7,
	[Display(Name = "*** Middel")]
	Middel = 8,
	[Display(Name = "**** Rutineret")]
	Rutineret = 9,
	[Display(Name = "***** Avanceret")]
	Avanceret = 10
}


