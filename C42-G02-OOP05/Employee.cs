using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP05
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid SecurityStamp { get; set; }
    }
}
