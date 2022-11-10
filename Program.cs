namespace Interface_demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    // Interfaces = requirements 
    // Make a interface that is a requirement for building a computer
    // We require a PSU, GPU and a CPU
    public interface IComputerBuild
    {
        void PSU();
        void GPU();
        void CPU();
    }
    // To inherit the IComputerBuild you need the components. 
    // A PSU, a GPU and a CPU
    public class BuildComputer : IComputerBuild
    {
        public void PSU()
        {
            Console.WriteLine("WagThatTail");
        }
        public void GPU()
        {
            Console.WriteLine("WagThatTail");
        }
        public void CPU()
        {
            Console.WriteLine("WagThatTail");
        }
    }
}