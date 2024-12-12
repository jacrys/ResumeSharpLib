using ResumeSharpLib;
using ResumeSharpLib.Utils.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ResumeSharpTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddJsonResumeTest()
        {
            JsonResume jsonResume = new JsonResume(); 
            jsonResume.AddAward(new Award())
                .AddWork(new Work())
                .AddVolunteer(new Volunteer())
                .AddEducation(new Education())
                .AddPublication(new Publication())
                .AddSkill(new Skill())
                .AddLanguage(new Language())
                .AddInterest(new Interest())
                .AddReference(new Reference())
                .AddCertificate(new Certificate())
                .AddProject(new Project());

            Assert.AreEqual(jsonResume.Awards.Count, 1);
            Assert.AreEqual(jsonResume.Works.Count, 1);
            Assert.AreEqual(jsonResume.Volunteers.Count, 1);
            Assert.AreEqual(jsonResume.Educations.Count, 1);
            Assert.AreEqual(jsonResume.Publications.Count, 1);
            Assert.AreEqual(jsonResume.Skills.Count, 1);
            Assert.AreEqual(jsonResume.Languages.Count, 1);
            Assert.AreEqual(jsonResume.Interests.Count, 1);
            Assert.AreEqual(jsonResume.References.Count, 1);
            Assert.AreEqual(jsonResume.Certificates.Count, 1);
            Assert.AreEqual(jsonResume.Projects.Count, 1);
        }

        [TestMethod]
        public void AddJsonJobTest()
        {
            JsonJob jsonJob = new JsonJob();
            jsonJob.AddSkill(new Skill())
                .AddQualification("")
                .AddResponsibility("");

            Assert.AreEqual(jsonJob.Skills.Count, 1);
            Assert.AreEqual(jsonJob.Qualifications.Count, 1);
            Assert.AreEqual(jsonJob.Responsibilities.Count, 1);
        }
    }
}
