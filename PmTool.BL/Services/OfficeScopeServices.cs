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
    public class OfficeScopeServices
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;
        public OfficeScopeServices()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        public List<OfficeScopes> ListOfficeScopes()
        {
            try
            {
                List<OfficeScopes> theListOfficeScopes = unitOfWork.Repository<OfficeScopes>().GetAll().ToList();
                return theListOfficeScopes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
