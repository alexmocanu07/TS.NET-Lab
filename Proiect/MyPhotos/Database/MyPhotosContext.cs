namespace Database
{
    public class MyPhotosContext
    {
        private static DatabaseModelContainer Context;
        private MyPhotosContext() { }

        public static DatabaseModelContainer GetContext()
        {
            if (Context == null)
            {
                Context = new DatabaseModelContainer();
            }
            return Context;
        }

    }
}
