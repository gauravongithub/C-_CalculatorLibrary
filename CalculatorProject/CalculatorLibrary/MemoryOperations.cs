using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;


namespace CalculatorLibrary
{
    public enum Memo { MemoryAdd, MemorySubtract, MemoryStore, MemoryRecall, MemoryClear };
    public class MemoryOperations
    {
        private static List<double> memory;
        private static ResourceManager exception;
        static MemoryOperations()
        {
            memory = new List<double>();
            exception = new ResourceManager("CalculatorApp.Properties.Resources", Assembly.GetExecutingAssembly());
        }
        public static void MemoryAdd(double result)
        {
            if (memory.Count == 0)
                memory.Add(result);
            memory[memory.Count - 1] += result;
        }
        public static void MemoryAdd(double result, int index)
        {
            if (index < 0 || index >= memory.Count)
                throw new MemoryException(exception.GetString("OutofBound"));
            memory[index] += result;
        }
        public static void MemorySubtract(double result)
        {
            if (memory.Count == 0)
                memory.Add(result);
            memory[memory.Count - 1] -= result;
        }
        public static void MemorySubtract(double result, int index)
        {
            if (index < 0 || index >= memory.Count)
                throw new MemoryException(exception.GetString("OutofBound"));
            memory[index] -= result;
        }
        public static void MemoryStore(double result)
        {
            memory.Add(result);
        }
        public static double MemoryRecall()
        {
            return memory[memory.Count - 1];
        }
        public static void MemoryClear()
        {
            memory.Clear();
        }
        public static List<double> viewMemory()
        {
            return memory;
        }

    }
}
