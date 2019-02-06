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
    public class FactoryService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;

        public FactoryService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        public Factories GetFactoryProjectBydId(int factoryProjectId )
        {
            try
            {
                return unitOfWork.Repository<Factories>().GetById(factoryProjectId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AddFactoryProject(Factories factory)
        {
            try
            {
                unitOfWork.Repository<Factories>().Add(factory);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateFactoryProject(Factories factory)
        {
            try
            {
                unitOfWork.Repository<Factories>().Update(factory);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteFactoryProject(Factories factory)
        {
            try
            {
                unitOfWork.Repository<Factories>().Delete(factory);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Factories> ListFactoriesProjects()
        {
            try
            {
                List<Factories> theListAllFactoriesProjects = unitOfWork.Repository<Factories>().GetAll().ToList();
                return theListAllFactoriesProjects;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Factories> ListFactoryProjectsByAssinedPm(int userId)
        {
            try
            {
                List<Factories> theFactoriesProjectsListByAssignedPm = unitOfWork.Repository<Factories>().FindAll(x => x.Assigned_pm == userId).ToList();
                return theFactoriesProjectsListByAssignedPm;
            }
            catch (Exception ex)
            {

                throw ex;
            }       
        }

        public List<Factories> ListFactoryProjectsByRequestorId(int userId)
        {
            try
            {
                List<Factories> theFactoriesProjectsListByRequestorId = unitOfWork.Repository<Factories>().FindAll(x => x.Factory_requestor_id == userId).ToList();
                return theFactoriesProjectsListByRequestorId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
