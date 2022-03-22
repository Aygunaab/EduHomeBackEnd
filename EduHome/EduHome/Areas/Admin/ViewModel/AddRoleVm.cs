using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.ViewModel
{
    public class AddRoleVm
    {
        public string UserId { get; set; }
        public List<string> Roles { get; set; }
        public string RoleName { get; set; }
    }
}
