namespace ConsoleApp1
{
    public sealed class Singleton          //Declare class as selaed to prevent further inheritance
    {
        private static Singleton instance = null;   //Declare static instance of the class

        private Singleton()  //Create a private constructor so that no one can create the object of the class
        {

        }

        public static Singleton GetInstance()        //create a method which will check wheteher instance is null 
        {
            if (instance == null)
            {
                instance = new Singleton();            //if null it will create a new instance 
            }

            return instance;   //otherwise it returns same instance
        }

        public void Method()
        {

        }
    }
}
