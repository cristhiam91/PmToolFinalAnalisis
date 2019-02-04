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

        public DataCenters GetDataCenterById(int id)
        {
            return unitOfWork.Repository<DataCenters>().GetById(id);
        }

    }
}
