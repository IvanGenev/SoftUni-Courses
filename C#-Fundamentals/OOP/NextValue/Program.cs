using System;

namespace NextValue
{
    public class Sequence
    {
        // Static field, holding the current sequence value
        private static int currentValue = 0;

        // Intentionally deny instantiation of this class
        private Sequence()
        {
        }

        // Static method for taking the next sequence value
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }

    class SequenceManipulating
    {
        static void Main()
        {
            Console.WriteLine("Sequence[1..3]: {0}, {1}, {2}", 
                Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());
        }
    }
}
