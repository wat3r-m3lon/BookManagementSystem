using BookManagementDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementDomain.Models.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Email { get; set; }
        public DateTime Created { get; set; }
    }
}
