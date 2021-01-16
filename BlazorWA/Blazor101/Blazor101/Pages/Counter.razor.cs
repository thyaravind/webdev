using System;
namespace Blazor101.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }


        public Counter()
        {
        }
    }
}
