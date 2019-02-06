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
    public class OfficeService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;

        public OfficeService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        public Offices GetOfficeProjectBydId(int officeProjectId)
        {
            try
            {
                return unitOfWork.Repository<Offices>().GetById(officeProjectId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AddOfficeProject(Offices office)
        {
            try
            {
                unitOfWork.Repository<Offices>().Add(office);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateOfficeProject(Offices office)
        {
            try
            {
               unitOfWork.Repository<Offices>().Update(office);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteOfficeProject(Offices office)
        {
            try
            {
                unitOfWork.Repository<Offices>().Delete(office);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Offices> ListOfficeProjects()
        {
            try
            {
                List<Offices> theListOfficeProjects = unitOfWork.Repository<Offices>().GetAll().ToList();
                return theListOfficeProjects;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Offices> ListOfficeProjectsByAssinedPm(int userId)
        {
            try
            {
                List<Offices> theListOfficeProjectsByAssinedPm = unitOfWork.Repository<Offices>().FindAll(x => x.Assigned_pm == userId).ToList();
                return theListOfficeProjectsByAssinedPm;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Offices> ListOfficeProjectsByRequestorId(int userId)
        {
            try
            {
                List<Offices> theListOfficeProjectsByRequestorId = unitOfWork.Repository<Offices>().FindAll(x => x.Office_requestor_id == userId).ToList();
                return theListOfficeProjectsByRequestorId;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
