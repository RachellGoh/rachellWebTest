using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string displayTxt { get; set; }

        private readonly string[] texts = { "Logic will get you from A to B.Imagination will take you everywhere.",
                               "There are 10 kinds of people.Those who know binary and those who don't.",
                               "It is pitch dark. You are likely to be eaten by a grue.",
                               "There are two ways of constructing a software design.One way is to make it so simple that there are obviously no deficiencies and the other is to make it so complicated that there are no obvious deficiencies.",
                               "It's not that I'm so smart, it's just that I stay with problems longer." };

        private static string[] temp = { };


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Random rand = new Random();
            if (temp.Length == 0)
            {
                temp = texts;
            }

            int arrIndex = rand.Next(temp.Length);
            displayTxt = temp[arrIndex];
            temp = temp.Where((source, index) => index != arrIndex).ToArray();
        }
    }
}