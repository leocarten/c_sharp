using System;
namespace cs_code{
    class Customer{
        public string Name;
        public int Age;
        public Customer(string name, int age){
            this.Name = name;
            this.Age = age;
        }

        public void setName(string newName){ // a setter method will change class variables for that object
            this.Name = newName;
        }

        public string getName(){
            return this.Name;
        }

    }
}