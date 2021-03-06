﻿using JobMe_Homepage.ApplierServiceReference;
using JobMe_Homepage.CompanyServiceReference;
using JobMe_Homepage.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobMe_Homepage.Controllers
{
    public class CompanyController : Controller
    {
        CompanyServiceClient client = new CompanyServiceClient();
        JobPostServiceReference.JobPostServiceClient jobClient = new JobPostServiceReference.JobPostServiceClient();
        JobApplicationServiceReference.JobApplicationServiceClient jobApplicationService = new JobApplicationServiceReference.JobApplicationServiceClient();
        ApplierServiceClient applierServiceClient = new ApplierServiceClient();
        // GET: Company
        public ActionResult Index()
        {
            Company company = new Company();
            // Mangler fagterm på as
            company = Session["company"] as Company;
            // Returns a list of all JobPost in the database - It sorts the list so it equals the CompanyId your logged in with
            List<JobPostServiceReference.JobPost> job = jobClient.GetAllJobPost().Where(m => m.company.Id == company.Id).ToList();
            VMCompanyANDJobPost vMCompanyANDJobPost = new VMCompanyANDJobPost
            {
                Company = company,
                JobPost = job
                
            };

            return View(vMCompanyANDJobPost);
        }

        public ActionResult _CreateCompany()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult _CreateCompany(string Email, string Password, string PasswordControl)
        {
            Company company = new Company();
            company.Email = Email;
            company.Password = Password;

            if (Password == PasswordControl)
            {
                client.CreateCompany(company);
                // Creates session on creation of user
                Session["company"] = company;
                return RedirectToAction("Index");
            }
            else
            {
                //Giv fejl omkring at password ikke stemmer overens
            }

            return null;
        }

        public ActionResult CreateJobPost()
        {
            VMWorkHoursJobCategory VM = new VMWorkHoursJobCategory();
            VM.WorkHoursList = client.GetlAllWorkHours().ToList();
            VM.JobCategoryList = client.GetAllJobCategories().ToList();
            return View(VM);
        }
        /// <summary>
        /// Create Job Post method, It creates a jobPost from a constructor with the required parameters.
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Description"></param>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="JobTitle"></param>
        /// <param name="WorkHours"></param>
        /// <param name="Address"></param>
        /// <param name="Company"></param>
        /// <param name="JobCategory"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateJobPost(string Title, string Description, DateTime StartDate, DateTime EndDate, string JobTitle, int WorkHours, string Address, Company Company, int JobCategory)
        {
            WorkHours workHours = new WorkHours { Id = WorkHours };
            CompanyServiceReference.JobCategory jobCategory = new CompanyServiceReference.JobCategory { Id = JobCategory };
            Company company =  Session["company"] as Company;
            JobPost jobPost = new JobPost
            {
                Title = Title,
                Description = Description,
                StartDate = StartDate.Date,
                EndDate = EndDate.Date,
                JobTitle = JobTitle,
                workHours = workHours,
                Address = Address,
                company = company,
                jobCategory = jobCategory
            };
            try
            {
                client.CreateJobPost(jobPost);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }

        }


        public ActionResult JobPost(int id)
        {
            JobPostServiceReference.JobPost jobPost = jobClient.GetJobPost(id);
            return View(jobPost);
        }

        [HttpPost]
        public ActionResult _Login(string email, string password)
        {
            Company company = client.Login(email, password);

            // Creates sessions for company login
            Session["company"] = company;

            return RedirectToAction("Index");
        }

        public ActionResult _CurrentCompany()
        {
            Company company = new Company();
            // Mangler fagterm på as
            company = Session["company"] as Company;
            return PartialView(company);
        }

        /// <summary>
        /// Returns all JobApplications from a specific JobPost
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult AppliersForJob(int id)
        {

            JobPost jobPost = new JobPost
            {
                Id = id
            };
            VMJobPostJobApplication vMJobPostJobApplication = new VMJobPostJobApplication
            {
               jobPost = jobPost,
                JobApplicationList = jobApplicationService.GetAllJobApplicationToAJobPost(id).ToList()
            };




            return View(vMJobPostJobApplication);
        }

        /// <summary>
        /// Appliers for job Method, takes the JobApplication, and JobPostId and a boolean, the boolean is a state that shows if they've been accepted to book a meeting.
        /// </summary>
        /// <param name="jobApplicationId"></param>
        /// <param name="jobPostId"></param>
        /// <param name="accepted"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AppliersForJob(int jobApplicationId, int jobPostId, int accepted)
        {
            JobApplicationServiceReference.JobApplication jobApplication = new JobApplicationServiceReference.JobApplication
            {
                Id = jobApplicationId
            };

            JobApplicationServiceReference.JobPost jobPost = new JobApplicationServiceReference.JobPost
            {
                Id = jobPostId
            };

            //Appliers for Job method takes an int for AcceptedApplication which is a bit in the database, if the int is 1 we sets the boolean to true.
            bool accept = false;
            if (accepted == 1)
            {
                accept = true;
            }
          
            jobApplicationService.AcceptDeclineJobApplication(jobApplication, jobPost, accept);
            return RedirectToAction("");
        }
            public ActionResult _JobApplication()
        {
            JobApplicationServiceReference.JobApplication jobApplication = new JobApplicationServiceReference.JobApplication();
            return PartialView(jobApplication);
        }

        public ActionResult _JobCV()
        {
            JobCV jobCV = new JobCV();
            return PartialView(jobCV);
        }
        

        public ActionResult Accept()
        {
            
            return RedirectToAction("ApplierForJob");
        }
    }
}