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
    public class ProjectTypeService
    {
        private readonly DbContext dbContext;
        private UnitOfWork unitOfWork;
        public ProjectTypeService()
        {
            this.dbContext = new ProjectManagementEntities();
            this.unitOfWork = new UnitOfWork(dbContext);
        }
   
        public List<ProjectTypes> ListProjectTypes()
        {
            try
            {
                List<ProjectTypes> theListProjectTypes = unitOfWork.Repository<ProjectTypes>().GetAll().ToList();
                return theListProjectTypes;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
