using System.Collections.Generic;

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
