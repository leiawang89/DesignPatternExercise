using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodingExercise
{
    /// <summary>
    /// This class has the responsibility of memory state management. 
    /// It will kepp track of the changed in the state of the robot memory.
    /// </summary>
    public class MemoryHistory
    {
       // create a list variable to store zero or more MemoryState object.
        private List<MemoryState> states = new List<MemoryState>();

        /// <summary>
        /// The push method add a new memory state in the MemoryHistory.
        /// </summary>
        /// <param name="state"></param>
        public void push(MemoryState state)
        {
            states.Add(state);
        }

        /// <summary>
        /// the pop method remove the return the last memory state.
        /// </summary>
        /// <returns> the last meomory state in the list. </returns>
        public MemoryState pop()
        {
            var lastIndex = states.Count() - 1;
            var lastState = states[lastIndex];
            states.Remove(lastState);

            return lastState;
        }
    }
}
