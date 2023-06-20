using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Application.ApplicationUser
{
    public class CurrentUser
    {
        public CurrentUser(string id, string name, IEnumerable<string> roles)
        {
            Id = id;
            Name = name;
            Roles = roles;
        }
    
        public string Id { get; set; } 
        public string Name { get; set; }
        public IEnumerable<string> Roles { get; set; }

        public bool IsInRole(string role) => Roles.Contains(role);
    }
}
