namespace ResumeSharpLib.Utils.Extensions
{
    public static class SkillExtensions
    {
        public static Skill AddSkillKeyword(this Skill skill, string skillKeyword)
        {
            Utilities.AddItemToList(skill.Keywords, skillKeyword);
            return skill;
        }
    }
}
