using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slon.Model.Enums
{
    public enum OrderStatus
    {
        Created = 1,
        Viewed = 2,
        Accepted = 3,
        InProgress = 4,
        Closed = 5,
        Rejected = 6,
        Canceled = 7
    }
}