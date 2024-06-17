using System;
using cs_code; // use all other classes in this namespace
namespace cs_code{
    class Program{
        public static void Main(string[] args){
            AoC1 adventOfCodeDay1 = new AoC1("/Users/leocarten/c_sharp/cs_code/input1.txt");
            Console.WriteLine($"Day 1 part 1 of 2020: {adventOfCodeDay1.solution1()}");
            Console.WriteLine($"Day 1 part 2 of 2020: {adventOfCodeDay1.solution2()}");
        }
    }
}