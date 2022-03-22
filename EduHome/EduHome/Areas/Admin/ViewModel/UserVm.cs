using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.ViewModel
{
    public class UserVm
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Roles { get; set; }
        public bool IsActive { get; set; }
    }
}
