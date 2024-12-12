using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeSharpLib.Utils.Extensions
{
    public static class SkillExtensions
    {
        public static Skill AddSkillKeyword(this Skill skill, Keyword skillKeyword)
        {
            Utilities.AddItemToList(skill.Keywords, skillKeyword);
            return skill;
        }
    }
}
