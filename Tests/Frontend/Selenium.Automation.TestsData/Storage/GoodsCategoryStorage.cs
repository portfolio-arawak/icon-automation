using System.Collections.Generic;
namespace Selenium.Automation.TestsData.Storage
{
    public static class GoodsCategoryStorage
    {
        public static Dictionary<string, string[]> Values
            = new Dictionary<string, string[]>
            {
                {"Platform", PlatformFilters}
            };
        private static string[] PlatformFilters =>
            new string[]
            {
                "Nintendo Switch",
                "PlayStation 1",
                "PlayStation 3",
                "PlayStation 4",
                "Playstation 5",
                "Sega",
                "Xbox 360",
                "Xbox One",
                "Xbox series S/X",
                "Портативні PlayStation",
                "Ретро приставки та консолі"
            };
    }
}
