using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORMApp.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// EmployeeProject table
    /// </summary>
    public class EmployeeProject
    {
        [Key]
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }

        [Key]
        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }

        public Employee Employee { get; set; }

        public Project Project { get; set; }
    }
}
