using System;
using cs_code.UnitTests;
namespace cs_code{
    class Program{
        public static void Main(string[] args){
            // AOC
            // AoC1 adventOfCodeDay1 = new AoC1("/Users/leocarten/c_sharp/cs_code/input1.txt");
            // Console.WriteLine($"Day 1 part 1 of 2020: {adventOfCodeDay1.solution1()}");
            // Console.WriteLine($"Day 1 part 2 of 2020: {adventOfCodeDay1.solution2()}");

            // Playing around
            // var customer = new Customer("Leo", 23);
            // Console.WriteLine(customer.Name);
            // customer.setName("I changed the name");
            // Console.WriteLine(customer.getName());

            // Find most common character in string
            // var stringTest = new StringStuff("Hello");
            // Console.WriteLine($"The most common character in '{stringTest.getString()}' is: {stringTest.getMostCommonChar()}");

            //  STACK OVERFLOW EXERCISE
            // var post = new StackOverflow("Leo's first post!", "This is the description of my first post.");
            // post.makeUpVote();post.makeUpVote();post.makeUpVote();post.makeUpVote();
            // post.makeDownVote();
            // post.setNewDesc("This is the edited description of the post.");
            // System.Console.WriteLine($"Title: {post.getTitle()}\nDesc: {post.getDesc()}\nTOC: {post.getTOC()}\nUp votes: {post.up_votes}\nDown votes: {post.down_votes}");

            // INHERITANCE
            // var text = new Text(); // the text object from the Text class inherits methods from the super class, which is PresentationObject. So, it will have a copy method, for example.

            // STACK
            // var stack = new Stack();
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);
            // System.Console.WriteLine(stack.pop());
            // System.Console.WriteLine(stack.pop());
            // System.Console.WriteLine(stack.pop());
            // System.Console.WriteLine(stack.pop());

            // DATABASE STUFF
            // var time = new TimeSpan();
            // var sqlDB = new SqlConnection("SQL_string", time);
            // sqlDB.Open();
            // sqlDB.Close();
            // var oracleDB = new OracleConnection("ORACLE_string", time);
            // oracleDB.Open();
            // oracleDB.Close();

            // Unit testing with interface
            var test = new CalculatorTests();
            System.Console.WriteLine($"Addition test: {test.testAdd()}");
            System.Console.WriteLine($"Division test: {test.testDiv()}");
            System.Console.WriteLine($"Multiplication test: {test.testMult()}");
            System.Console.WriteLine($"Subtraction test: {test.testSub()}");

            
        }
    }
}