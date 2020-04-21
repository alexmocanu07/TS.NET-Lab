using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class MyPhotosContext
    {
        private static DatabaseModelContainer Context;
        private MyPhotosContext() { }

        public static DatabaseModelContainer GetContext()
        {
            if(Context == null)
            {
                Context = new DatabaseModelContainer();
            }
            return Context;
        }

    }
}
