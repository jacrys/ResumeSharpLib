using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace ResumeSharpLib.Utils
{
    class Utilities
    {
        public static void  AddItemToList<T>(List<T> list, T item)
        {
            if (list == null)
                list = new List<T>();

            list.Add(item);
        }
    }
}
