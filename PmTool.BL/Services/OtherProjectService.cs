using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PmTool.DAL.Repository;
using System.Data.Entity;
using PmTool.DAL;
using PmTool.DATA;

namespace PmTool.BL.Services
{
    public class OtherProjectService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;

        public OtherProjectService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }
        public OtherProjects GetOtherProjectBydId(int otherProjectId)
        {
            try
            {
                return unitOfWork.Repository<OtherProjects>().GetById(otherProjectId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AddOtherProject(OtherProjects otherProject)
        {
            try
            {
                unitOfWork.Repository<OtherProjects>().Add(otherProject);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateOtherProject(OtherProjects otherProject)
        {
            try
            {
                unitOfWork.Repository<OtherProjects>().Update(otherProject);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteOtherProject(OtherProjects otherProject)
        {
            try
            {
                unitOfWork.Repository<OtherProjects>().Delete(otherProject);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<OtherProjects> ListOtherProjects()
        {
            try
            {
                List<OtherProjects> theListOtherProjects = unitOfWork.Repository<OtherProjects>().GetAll().ToList();
                return theListOtherProjects;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<OtherProjects> ListOtherProjectsByAssinedPm(int userId)
        {
            try
            {
                List<OtherProjects> theListtheListOtherProjectsProjectsByAssinedPm = unitOfWork.Repository<OtherProjects>().FindAll(x => x.Assigned_pm == userId).ToList();
                return theListtheListOtherProjectsProjectsByAssinedPm;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<OtherProjects> ListOtherProjectsByRequestorId(int userId)
        {
            try
            {
                List<OtherProjects> theListOtherProjectsByRequestorId = unitOfWork.Repository<OtherProjects>().FindAll(x => x.Other_requestor_id == userId).ToList();
                return theListOtherProjectsByRequestorId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
