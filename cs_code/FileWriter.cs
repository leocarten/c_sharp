// get user input from command line
// write to FileToWriteTo.cs
// Alert the user the file has been written to
using System;
namespace cs_code{
    class FileWriter{
        private string Path;
        public FileWriter(string path){
            this.Path = path;
        }

        public void Write(){
            string content = getUserInput();
            if(content != ""){
                // write to file
                File.WriteAllText(this.Path, content);
                System.Console.WriteLine("File successfully written to.");
            }
        }

        public string getUserInput(){
            Console.WriteLine("Enter content:");
            string? content = Console.ReadLine();
            if (content != null){
                Console.WriteLine($"Writing {content} to {this.Path}");
                return content;
            }
            else{
                Console.WriteLine("File content cannot be null.");
                return "";
            }
        }

    }
}