using System;
using System.Collections;
namespace cs_code{
    class Stack{
        private object[] stack = new object[0];
        public void Push(object obj){
            object[] tempStack = new object[stack.Length + 1];
            if(obj != null){
                tempStack[0] = obj;
                for(int i = 0; i < stack.Length; i++){
                    tempStack[i + 1] = stack[i];
                }
                stack = tempStack;
            }
        }

        public object pop(){
            // remove element from top (first position)
            if(stack.Length > 0){
                object itemToReturn = stack[0];
                object[] tempStack = new object[stack.Length - 1];
                for(int i = 1; i < stack.Length; i++){
                    tempStack[i - 1] = stack[i];
                }
                stack = tempStack;
                return itemToReturn;
            }
            throw new InvalidOperationException("Stack is empty.");
        }

        public void clear(){
            object[] stack_ = new object[0];
            stack = stack_;
        }

    }
}