using System;
using System.Dynamic;
namespace cs_code{
    class StackOverflow{
        private string Title;
        private string Desc;
        private DateTime TOC;
        public int down_votes = 0;
        public int up_votes = 0;
        public StackOverflow(string title, string desc){
            this.Title = title;
            this.Desc = desc;
            this.TOC = DateTime.Now;
        }

        public string getTitle(){
            return this.Title;
        }

        public string getDesc(){
            return this.Desc;
        }

        public DateTime getTOC(){
            return this.TOC;
        }

        public void makeUpVote(){
            this.up_votes++;
        }

        public void makeDownVote(){
            this.down_votes++;
        }

        public void setNewDesc(string newDesc){
            this.Desc = newDesc;
        }

    }
}