using System;
namespace cs_code{
    class AoC1{
        private string path_;
        public AoC1(string path){
            this.path_ = path;
        }
        public int solution1(){
            string[] lines = File.ReadAllLines(path_);
            foreach (string line1 in lines){
                foreach (string allOtherLines in lines){
                    if (Int32.Parse(line1) + Int32.Parse(allOtherLines) == 2020){
                        return Int32.Parse(line1) * Int32.Parse(allOtherLines);
                    }
                }
            }
            return -1;
        }

        public int solution2(){
            string[] lines = File.ReadAllLines(path_);
            foreach (string line1 in lines){
                foreach (string allOtherLines in lines){
                    foreach (string allOtherLines2 in lines){
                        if (Int32.Parse(line1) + Int32.Parse(allOtherLines) + Int32.Parse(allOtherLines2)== 2020){
                            // Console.WriteLine(line1);
                            // Console.WriteLine(allOtherLines);
                            // Console.WriteLine(allOtherLines2);
                            int result = (Int32.Parse(line1) * Int32.Parse(allOtherLines) * Int32.Parse(allOtherLines2));
                            return result;
                        }
                    }
                }
            }
            return -1; 
        }

    }
}