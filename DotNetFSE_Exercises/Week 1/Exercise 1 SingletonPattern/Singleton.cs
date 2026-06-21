using System;

namespace Exercise_1_SingletonPattern
{
    public class Singleton
    {
        
        private static Singleton instance;

        
        private Singleton()
        {
            Console.WriteLine("Singleton Instance Created");
        }

        
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

      
        public void DisplayMessage()
        {
            Console.WriteLine("Hello from Singleton Pattern!");
        }
    }
}
