using System;
namespace cs_code{
    interface I_calculator{
        int add(int[] array_);
        int subtract(int num1, int num2);
        float divide(int num1, int num2);
        int multiply(int num1, int num2);
    }
    class Calculator : I_calculator{
        public int add(int[] array_){
            int sum = 0;
            for(int i = 0; i < array_.Length; i++){
                sum += array_[i];
            }
            return sum;
        }
        public int subtract(int num1, int num2){
            return num1 - num2;
        }
        public float divide(int num1, int num2){
            return num1 / num2;
        }
        public int multiply(int num1, int num2){
            return num1 * num2;
        }
    }
}