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
    public class LaboratoryScopeService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;

        public LaboratoryScopeService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        public List<LabScopes> ListDataCenterScopes()
        {
            try
            {
                List<LabScopes> theListDataCenterScopes = unitOfWork.Repository<LabScopes>().GetAll().ToList();
                return theListDataCenterScopes;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
