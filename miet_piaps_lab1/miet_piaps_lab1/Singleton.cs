using System;
using System.Collections.Generic;
using System.Text;

/* 
 1.	С использованием одного из языков программирования из множества (C++, C#) реализовать паттерн
    порождающего проектирования Одиночка (singleton).
 
 */

namespace miet_piaps_lab1
{
    class Singleton
    {

        private static Singleton single = null; 

        // конструктор по умолчанию для того, чтобы мы не могли присвоить new Singleton 
        protected Singleton() 
        {

        }

        public static Singleton Initialize()
        {
            if (single == null)
                single = new Singleton();
            return single;
        }



    }
}
