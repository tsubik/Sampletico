﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sampletico.ViewModels
{
    public class UserEditViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}