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
   public class FactoryScopeService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;

        public FactoryScopeService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        public List<FabScopes> ListFactoryScopes()
        {
            try
            {
                List<FabScopes> theListFactoryScopes = unitOfWork.Repository<FabScopes>().GetAll().ToList();
                return theListFactoryScopes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
