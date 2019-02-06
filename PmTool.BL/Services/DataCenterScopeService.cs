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
    public class DataCenterScopeService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;

        public DataCenterScopeService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        public List<DcScopes> ListDataCenterScopes()
        {
            try
            {
                List<DcScopes> theListDcScopes = unitOfWork.Repository<DcScopes>().GetAll().ToList();
                return theListDcScopes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
  
        }
    }
}
