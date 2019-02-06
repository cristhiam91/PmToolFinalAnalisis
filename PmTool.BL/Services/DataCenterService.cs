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
    public class DataCenterService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;

        public DataCenterService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        /// <summary>
        /// The method get a Id from user and return the data center with the same Id.
        /// </summary>
        /// <param name="id">Data center id</param>
        /// <returns>The object data center with the id</returns>
        public DataCenters GetDataCenterById(int id)
        {
            try
            {
                return unitOfWork.Repository<DataCenters>().GetById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

   

        //public List<DataCenters> listAllUserDataCenterProjects(int userId)
        //{
        //    List<DataCenters> theListOfAllUserDataCenters = unitOfWork.Repository<DataCenters>().GetAll().Where

        //}

        public void AddDataCenterProject(DataCenters dataCenter)
        {
            try
            {
                unitOfWork.Repository<DataCenters>().Add(dataCenter);
            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }

        public void UpdateDataCenterProject(DataCenters dataCenter)
        {
            try
            {
                unitOfWork.Repository<DataCenters>().Update(dataCenter);
            }
            catch (Exception ex)
            {

                throw ex;
            }          
        }

        //validar
        public void DeleteDataCenterProject(DataCenters dataCenters)
        {
            try
            {
                unitOfWork.Repository<DataCenters>().Delete(dataCenters);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// The method get all the data centers of the data base
        /// </summary>
        /// <returns>A list of all the data centers</returns>
        public List<DataCenters> ListAllDataCenterProjects()
        {
            try
            {
                List<DataCenters> theListAllDataCenterProjects = unitOfWork.Repository<DataCenters>().GetAll().ToList();
                return theListAllDataCenterProjects;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<DataCenters> ListDataCenterByAssignedPm(int userId)
        {
            try
            {
                List<DataCenters> theDataCenterProjectsListByAssignedPm = unitOfWork.Repository<DataCenters>().FindAll(x => x.Assigned_pm == userId).ToList();
                return theDataCenterProjectsListByAssignedPm;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<DataCenters> ListDataCenterProjecByRequestorId(int userId)
        {
            try
            {
                List<DataCenters> theDataCenterProjecByRequestorId = unitOfWork.Repository<DataCenters>().FindAll(x => x.DataCenter_requestor_id == userId).ToList();
                return theDataCenterProjecByRequestorId;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
