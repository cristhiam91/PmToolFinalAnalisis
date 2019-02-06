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
    public class SpeedConnectionTypeService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;

        public SpeedConnectionTypeService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        public List<SpeedConnectionTypes> ListSpeedConnectionTypes()
        {
            try
            {
                List<SpeedConnectionTypes> theListSpeedConnectionTypes = unitOfWork.Repository<SpeedConnectionTypes>().GetAll().ToList();
                return theListSpeedConnectionTypes;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
