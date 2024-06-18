using System;
using System.Collections.Generic;
namespace cs_code{
    class StringStuff{
        private string String;
        public StringStuff(string string_){
            this.String = string_;
        }

        public char getMostCommonChar(){
            // vars
            Dictionary<char, int> map = new Dictionary<char, int>();
            int highest = 0;
            char char_ = ' ';

            // iterate over chars in string
            foreach(char character in this.String){
                if(map.ContainsKey(character)){
                    map[character]++;
                }else{
                    map.Add(character, 1);
                }
            }

            // get most frequent letter
            foreach (KeyValuePair<char, int> entry in map){
                if(entry.Value > highest){
                    highest = entry.Value;
                    char_ = entry.Key;
                }
            }

            return char_;
        }

        public string getString(){
            return this.String;
        }

    }
}