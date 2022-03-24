using Microsoft.AspNetCore.Components;

namespace BlazorServer.Pages
{
    public class CounterBase : ComponentBase
    {
        public int currentCount = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}
