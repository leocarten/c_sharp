using System;
namespace cs_code{
    interface I_ExecutionStages{
        public void Execute(string[] commands);
    }

    class ExecutionStages : I_ExecutionStages{
        private string NameOfCommand;
        public ExecutionStages(string nameOfCommand){
            this.NameOfCommand = nameOfCommand;
        }
        public void Execute(string[] commands){
            int step = 1;
            System.Console.WriteLine($"Command name: {this.NameOfCommand}");
            foreach(string command in commands){
                System.Console.WriteLine($"Step {step}: {command}");
                step++;
            }
        }
    }

}