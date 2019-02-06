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

    public class ConnectionTypeService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;

        public ConnectionTypeService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }
        public List<ConnectionTypes> ListConnectionTypes()
        {
            try
            {
                List<ConnectionTypes> theListConnectionTypes = unitOfWork.Repository<ConnectionTypes>().GetAll().ToList();
                return theListConnectionTypes;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
