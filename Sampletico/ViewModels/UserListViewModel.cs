using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sampletico.ViewModels
{
    public class UserListViewModel
    {
        public IEnumerable<UserListItemViewModel> Users { get; set; }
    }

    public class UserListItemViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}