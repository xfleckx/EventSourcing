﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    interface IUniqueEntity
    {
        Guid Guid { get; }
    }
}
