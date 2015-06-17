namespace WcfService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using System.ServiceModel;

    [DataContract]
    public partial class tbEmployee
    {
        [Key]
        [DataMember]
        [StringLength(10)]
        
        public string EmployeeID { get; set; }
  
        [StringLength(30)]
        [DataMember]
        public string EmployeeName { get; set; }

        [StringLength(30)]
        [DataMember]
      
        public string EmployeeDepartment { get; set; }
        [DataMember]
       
        public double? EmployeeSalary { get; set; }
    }
}
