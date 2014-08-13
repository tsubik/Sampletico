using Sampletico.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sampletico.Validation
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var user = UserService.FindByEmail(value.ToString());
            return user == null;
        }
    }
}