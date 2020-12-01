using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    /// <summary>
    /// This class has the responsibility of storing the state of memory at a given time.
    /// </summary>
    public class MemoryState
    {
        private string memory;

        //constuctor
        public MemoryState(string memory)
        {
            this.memory = memory;
        }

        //getter
        public string getMemory()
        {
            return memory;
        }
    }
}
