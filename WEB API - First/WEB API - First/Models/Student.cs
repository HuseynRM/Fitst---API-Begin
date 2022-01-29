using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API___First.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Surname { get; set; }
        public bool Isdeleted { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<DateTime> UpdateAt { get; set; }
        public string UpdateBy { get; set; }

    }
}
