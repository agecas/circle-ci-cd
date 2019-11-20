using System;
using UselessProject.Engine.Abstractions;

namespace UselessProject.Engine
{
    public class HardcodedUselessService : IUselessService
    {
        public int CalculateUselessNumber()
        {
            return 42;
        }
    }
}
