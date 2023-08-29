using BlazorSmack.Models;
using System.Threading.Tasks.Sources;

namespace BlazorSmack.Pages
{
    public partial class BlazorSmackComponent
    {
        int score  = 0;
        int currentTime = 60;
        int hitPosition = 0;
        string message = "";
        int gameSpeed = 500;
        bool isGameRunning = true;

        public List<SquareModel> Squares { get; set; } = new List<SquareModel>();

        public BlazorSmackComponent()
        {
            for (int i = 0; i < 9; i++)
            {
                Squares.Add(new SquareModel { Id = 1 });
            }

        }
    }
}
