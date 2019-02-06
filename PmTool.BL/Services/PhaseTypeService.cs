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
    public class PhaseTypeService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;

        public PhaseTypeService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        public List<PhaseTypes> ListPhaseTypeScopes()
        {
            try
            {
                List<PhaseTypes> thePhaseTypeScopes = unitOfWork.Repository<PhaseTypes>().GetAll().ToList();
                return thePhaseTypeScopes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
