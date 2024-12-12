using System;
using System.Collections.Generic;
using System.Text;
using ResumeSharpLib.Utils;

namespace ResumeSharpLib.Utils.Extensions
{
    public static class JsonResumeExtensions
    {

        /// <summary>
        /// Adds a work item to the resume object 
        /// </summary>
        /// <param name="jsonResume">The resume object</param>
        /// <param name="work">The work item</param>
        /// <returns></returns>
        public static JsonResume AddWork(this JsonResume jsonResume,Work work)
        { 

            Utilities.AddItemToList(jsonResume.Works, work);
            return jsonResume;
        }

        /// <summary>
        /// Adds a volunteer item to the resume object
        /// </summary>
        /// <param name="jsonResume"></param>
        /// <param name="volunteer"></param>
        /// <returns></returns>
        public static JsonResume AddVolunteer(this JsonResume jsonResume,Volunteer volunteer)
        {
            Utilities.AddItemToList(jsonResume.Volunteers, volunteer);
            return jsonResume;
        }

        /// <summary>
        /// Adds an education item to the resume object
        /// </summary>
        /// <param name="jsonResume">the resume object</param>
        /// <param name="education">the education item</param>
        /// <returns></returns>
        public static JsonResume AddEducation(this JsonResume jsonResume, Education education)
        {
            Utilities.AddItemToList(jsonResume.Educations, education);
            return jsonResume;
        }

        /// <summary>
        /// Adds a skill item to the resume object
        /// </summary>
        /// <param name="jsonResume">the resume object</param>
        /// <param name="skill">the skill item</param>
        /// <returns></returns>
        public static JsonResume AddSkill(this JsonResume jsonResume, Skill skill)
        {
            Utilities.AddItemToList(jsonResume.Skills, skill);
            return jsonResume;
        }


        /// <summary>
        /// Adds a language item to the resume object   
        /// </summary>
        /// <param name="jsonResume">the resume object</param>
        /// <param name="language">the language item</param>
        /// <returns></returns>
        public static JsonResume AddLanguage(this JsonResume jsonResume, Language language)
        {
            Utilities.AddItemToList(jsonResume.Languages, language);
            return jsonResume;
        }

        /// <summary>
        /// Adds an award item to the resume object
        /// </summary>
        /// <param name="jsonResume">the resume object</param>
        /// <param name="award">the award item</param>
        /// <returns></returns>
        public static JsonResume AddAward(this JsonResume jsonResume, Award award)
        {
            Utilities.AddItemToList(jsonResume.Awards, award);
            return jsonResume;
        }

        /// <summary>
        /// Adds an interest item to the rrsume object
        /// </summary>
        /// <param name="jsonResume">the resume object</param>
        /// <param name="interest">the interest item</param>
        /// <returns></returns>
        public static JsonResume AddInterest(this JsonResume jsonResume,Interest interest)
        {
            Utilities.AddItemToList(jsonResume.Interests, interest);
            return jsonResume;
        }

        /// <summary>
        /// Adds a publication item to the resume
        /// </summary>
        /// <param name="jsonResume">the resume object</param>
        /// <param name="publication">the publication item</param>
        /// <returns></returns>
        public static JsonResume AddPublication(this JsonResume jsonResume, Publication publication)
        {
            Utilities.AddItemToList(jsonResume.Publications, publication);
            return jsonResume;
        }

        /// <summary>
        /// Adds a reference item to the resume object
        /// </summary>
        /// <param name="jsonResume">the resume object</param>
        /// <param name="reference">the reference item</param>
        /// <returns></returns>
        public static JsonResume AddReference(this JsonResume jsonResume, Reference reference)
        {
            Utilities.AddItemToList(jsonResume.References, reference);
            return jsonResume;
        }

        /// <summary>
        /// Adds a certificate item to the resume object
        /// </summary>
        /// <param name="jsonResume">the resume object</param>
        /// <param name="certificate">the certificate item</param>
        /// <returns></returns>
        public static JsonResume AddCertificate(this JsonResume jsonResume, Certificate certificate)
        {
            Utilities.AddItemToList(jsonResume.Certificates, certificate);
            return jsonResume;
        }

        /// <summary>
        /// Adds a project item to the resume object
        /// </summary>
        /// <param name="jsonResume">the resume object</param>
        /// <param name="project">the project item</param>
        /// <returns></returns>
        public static JsonResume AddProject(this JsonResume jsonResume, Project project)
        {
            Utilities.AddItemToList(jsonResume.Projects, project);
            return jsonResume;
        }
    }
}
