using System.ComponentModel;

namespace NygarnDemo.Enums
{
	public enum DifficultyLevel
	{
		[Description("1 ud af 5")]
		DiffLevelOne = 1,
		[Description("2 ud af 5")]
		DiffLevelTwo = 2,
		[Description("3 ud af 5")]
		DiffLevelThree = 3,
		[Description("4 ud af 5")]
		DiffLevelFour = 4,
		[Description("5 ud af 5")]
		DiffLevelFive = 5,
		[Description("* Nybegynder")]
		DiffLevelSix = 6,
		[Description("** Enkel")]
		DiffLevelSeven = 7,
		[Description("*** Middel")]
		DiffLevelEight = 8,
		[Description("**** Rutineret")]
		DiffLevelNine = 9,
		[Description("***** Avanceret")]
		DiffLevelTen = 10
	}
}
