﻿using System;
namespace Partial_Classes
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return _firstName + ", " + _lastName;
        }
    }
}
