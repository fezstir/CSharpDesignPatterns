using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGenerator
    {
        /*
         * private access modiferthat restricts access to the class only. 
         * static- no instance of this variable are created
         * 
         volatile - notes that variable may be modified by multiple threads
             */
        private static volatile SerialNumberGenerator instance;

        /* object - root of all objects in .Net*/
        private static object synchronizationRoot = new object();

        private int _count = 12345;
        /* propertyof the class SerialNumberGenerator */

        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }
        private SerialNumberGenerator() { }

        public int NextSerial
        {
            get { return ++_count; }
        }
    }
}
