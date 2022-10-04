using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;
using GameSite.Data;
namespace GameSite.Pages
{
    public partial class Counter
    {
        public static int currentCount = 0;

        public static void IncrementCount()
        {
            WeatherForecast.a++;
        }
    }
}
