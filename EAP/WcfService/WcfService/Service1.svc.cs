using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        
        DBEmployees db = new DBEmployees();
        public void AddEmployees(tbEmployee e)
        {
            //goi tu bang
            db.tbEmployees.Add(e);


            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }


        }

        public tbEmployee SearchEmployees(string id)
        {
            foreach (var item in db.tbEmployees)
            {
                if ((item.EmployeeID.ToLower()).Contains(id.ToLower()))
                {
                    return item;
                }
                
            }
            return null;
        }

        public List<tbEmployee> GetEmployees()
        {
            return db.tbEmployees.ToList<tbEmployee>();

        }
    }
}
