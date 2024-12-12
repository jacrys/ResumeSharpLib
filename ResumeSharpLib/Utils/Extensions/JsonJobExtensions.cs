using System;
using System.Collections.Generic;
using System.Text;
using ResumeSharpLib.Utils;

namespace ResumeSharpLib.Utils.Extensions
{
    public static class JsonJobExtensions
    {
        /// <summary>
        /// Adds a skill item to the job object
        /// </summary>
        /// <param name="jsonJob">the job object</param>
        /// <param name="skill">the skill item</param>
        /// <returns></returns>
        public static JsonJob AddSkill(this JsonJob jsonJob, Skill skill)
        {
            Utilities.AddItemToList(jsonJob.Skills, skill);
            return jsonJob;
        }

        public static JsonJob AddQualification(this JsonJob jsonJob, string qualification)
        {
            Utilities.AddItemToList(jsonJob.Qualifications, qualification);
            return jsonJob;
        }

        public static JsonJob AddResponsibility(this JsonJob jsonJob, string responsibility)
        {
            Utilities.AddItemToList(jsonJob.Responsibilities, responsibility);
            return jsonJob;
        }
    }
}
