using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Slon.Model.Enums
{
    public enum ItemDimensionEnum
    {
        [Display(Name = "шт")]
        Items = 1,
        [Display(Name = "кг")]
        Kg = 2,
        [Display(Name = "л")]
        L = 3
    }
}