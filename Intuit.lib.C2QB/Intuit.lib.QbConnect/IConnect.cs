﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intuit.lib.C2QB
{
    interface IConnect<T>
    {
        bool Validate(T objectType);
        void Connect(T objectType,out QbResponse qbResponse);
    }
}
