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
    public class UserService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;

        public UserService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }
        public Labs GetUserBydId(int userId)
        {
            try
            {
                return unitOfWork.Repository<Labs>().GetById(userId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AddLaboratoryProject(Labs laboratory)
        {
            try
            {
                unitOfWork.Repository<Labs>().Add(laboratory);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateLaboratoryProject(Labs laboratory)
        {
            try
            {
                unitOfWork.Repository<Labs>().Update(laboratory);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteLaboratoryProject(Labs laboratory)
        {
            try
            {
                unitOfWork.Repository<Labs>().Delete(laboratory);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Labs> ListLaboratoryProjects()
        {
            try
            {
                List<Labs> theListLaboratoryProjects = unitOfWork.Repository<Labs>().GetAll().ToList();
                return theListLaboratoryProjects;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Labs> ListLaboratoryProjectsByAssinedPm(int userId)
        {
            try
            {
                List<Labs> theListLaboratoryProjectsByAssinedPm = unitOfWork.Repository<Labs>().FindAll(x => x.Assigned_pm == userId).ToList();
                return theListLaboratoryProjectsByAssinedPm;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Labs> ListLaboratoryProjectsByRequestorId(int userId)
        {
            try
            {
                List<Labs> theListLaboratoryProjectsByRequestorId = unitOfWork.Repository<Labs>().FindAll(x => x.Lab_requestor_id == userId).ToList();
                return theListLaboratoryProjectsByRequestorId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
