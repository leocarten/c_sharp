using System;
namespace cs_code{
    class PresentationObject{
        public int Width {get; set;}
        public int Height {get; set;}
        public void Copy(){
            System.Console.WriteLine("Shape copied to clipboard.");
        }
    }

    class Text : PresentationObject{ // this text class (and objects from text class) will inherit the Copy() method from the super class, PresentationObject
        public int FontSize {get; set;}
        // public string FontType {get; set;}
        public static void AddHyper(string url){
            System.Console.WriteLine("Added URL.");
        }
    }

}