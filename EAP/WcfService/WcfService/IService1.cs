using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void AddEmployees(tbEmployee e);



        [OperationContract]
        tbEmployee SearchEmployees(string id);

        [OperationContract]
        List<tbEmployee> GetEmployees();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class Employee
    //{
    //    [FaultContract(typeof(ValidationException))]
    //    [DataMember]
    //    public string EmployeeID {get; set;}
    //    [FaultContract(typeof(ValidationException))]
    //    [DataMember]
    //    public string EmployeeName {get; set;}
    //    [FaultContract(typeof(ValidationException))]
    //    [DataMember]
    //    public string  EmployeeDepartment {get; set;}

    //   [DataMember]
    //    public float EmployeeSalary {get; set;}
        
    //}
}
