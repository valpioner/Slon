using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Slon.Model.Enums
{
    public enum ItemSizeEnum
    {
        [Display(Name = "0.1")]
        _0_1 = 1,
        [Display(Name = "0.2")]
        _0_2 = 2,
        [Display(Name = "0.25")]
        _0_25 = 3,
        [Display(Name = "0.3")]
        _0_3 = 4,
        [Display(Name = "0.33")]
        _0_33 = 5,
        [Display(Name = "0.4")]
        _0_4 = 6,
        [Display(Name = "0.5")]
        _0_5 = 7,
        [Display(Name = "0.6")]
        _0_6 = 8,
        [Display(Name = "0.7")]
        _0_7 = 9,
        [Display(Name = "0.8")]
        _0_8 = 10,
        [Display(Name = "0.9")]
        _0_9 = 11,
        [Display(Name = "1")]
        _1 = 12,
        [Display(Name = "5")]
        _5 = 13,

    }
}