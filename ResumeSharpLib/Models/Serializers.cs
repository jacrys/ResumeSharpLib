using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeSharpLib
{
    public static class ResumeSerialize
    {
        /// <summary>
        /// Convert the JsonResume object to json
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string ToJson(this JsonResume self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public static class JobSerialize
    {
        /// <summary>
        /// Convert the JsonResume object to json
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string ToJson(this JsonResume self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
