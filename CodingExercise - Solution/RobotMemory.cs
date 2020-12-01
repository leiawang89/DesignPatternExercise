using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    /// <summary>
    /// This class is responsible for holding memory that may change over time. 
    /// I also defines a method for saving its state inside a 
    /// MemoryState and a method for restoring the state from it.
    /// </summary>
    public class RobotMemory
    {
        // create a string variable to store the current memory.
        private string memory;

        /// <summary>
        /// This method stores the current memory state of robot memory inside a state object and returns it.
        /// </summary>
        /// <returns> returns the current memory state of robot memory. </returns>
        public MemoryState createMemory()
        {
            return new MemoryState(memory);
        }

        /// <summary>
        /// This method takes a MemoryState object and brings this memory back to that state.
        /// </summary>
        /// <param name="state"> an object of MemoryState</param>
        public void restoreMemory(MemoryState state)
        {
            memory = state.getMemory();
        }

        /// <summary>
        /// Getter for the local memory field.
        /// </summary>
        /// <returns> the value of memory. </returns>
        public string getMemory()
        {
            return memory;
        }

        //constructor
        public void setMemory(string memory)
        {
            this.memory = memory;
        }
    }
}
