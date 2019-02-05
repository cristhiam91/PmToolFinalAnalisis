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
            return unitOfWork.Repository<DataCenters>().GetById(id);
        }

        /// <summary>
        /// The method get all the data centers of the data base
        /// </summary>
        /// <returns>A list of all the data centers</returns>
        public List<DataCenters> listAllDataCenterProjects()
        {
            List<DataCenters> theListOfAllDataCenters = unitOfWork.Repository<DataCenters>().GetAll().ToList();
            return theListOfAllDataCenters;
        }

        public List<DataCenters> listAllUserDataCenterProjects(int userId)
        {
            List<DataCenters> theListOfAllUserDataCenters = unitOfWork.Repository<DataCenters>().GetAll().ToList();

        }

    }
}
