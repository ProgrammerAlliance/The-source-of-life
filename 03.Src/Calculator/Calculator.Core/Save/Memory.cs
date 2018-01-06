namespace Calculator.Core
{
    public class Memory
    {
        public double MemoryNumber;

        public void MemorySave(double num)
        { 
             MemoryNumber = num;
        }

        public double MemoryRead()
        {
            return MemoryNumber;
        }

        public void MemoryClean()
        {
            MemoryNumber = 0;
        }

        public void MemoryAdd(double num)
        {
            MemoryNumber += num;
        }

        public void MemorySub(double num)
        {
            MemoryNumber -= num;
        }
    }
}
