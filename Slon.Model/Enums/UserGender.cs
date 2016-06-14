using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Slon.Model.Enums
{
    public enum UserGender
    {
        [Display(Name = "чол")]
        Male = 1,
        [Display(Name = "жін")]
        Female = 2,
        [Display(Name = "мабуть середня")]
        Unknown = 3
    }
}