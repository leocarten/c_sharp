using System;
namespace cs_code.UnitTests{
    class CalculatorTests{
        Calculator calc = new Calculator();
        public bool testAdd(){
            int[] test_array = {1,2,3,4};
            return calc.add(test_array) == 10;
        }
        public bool testSub(){
            return calc.subtract(13, 3) == 10;
        }
        public bool testDiv(){
            return calc.divide(100,10) == 10.0;
        }
        public bool testMult(){
            return calc.multiply(3,4) == 12;
        }
    }
}