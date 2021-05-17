namespace Namespace
{
    public class Singleton
    {
        private static Singleton instance { get; set; }
        private static readonly object @lock = new object();

        private Singleton()
        {
            //TODO: Implement Singleton
        }

        public static Singleton GetInstance()
        {
            if (instance != null) return instance;
            lock (@lock)
            {
                instance ??= new Singleton();
            }

            return instance;
        }
    }
}