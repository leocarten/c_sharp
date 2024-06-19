using System;
namespace cs_code{
    abstract class DbConnection{
        protected string ConnectionString;
        protected TimeSpan Timeout;
        public DbConnection(string connectionStr_, TimeSpan timeout_){
            if(connectionStr_ != null){
                this.ConnectionString = connectionStr_;
                this.Timeout = timeout_;
            }else{ //constrcutor needs else statement lol
                throw new Exception("Cannot connect with empty connection string.");
            }
        }
        abstract public void Open();

        abstract public void Close();

    }

    class SqlConnection : DbConnection{
        public SqlConnection(string connectionStr, TimeSpan timeout)
            : base(connectionStr, timeout){
                this.ConnectionString = connectionStr;
                this.Timeout = timeout;
        }
        public override void Open(){
            System.Console.WriteLine($"Opening SQL connection with {this.ConnectionString}");
        }
        public override void Close(){
            System.Console.WriteLine($"Closing SQL connection with {this.ConnectionString}");
        }
    }

    class OracleConnection : DbConnection{
        public OracleConnection(string connectionStr, TimeSpan timeout)
            : base(connectionStr, timeout){
                this.ConnectionString = connectionStr;
                this.Timeout = timeout;
        }
        public override void Open(){
            System.Console.WriteLine($"Opening Oracle connection with {this.ConnectionString}");
        }
        public override void Close(){
            System.Console.WriteLine($"Closing Oracle connection with {this.ConnectionString}");
        }
    }

}