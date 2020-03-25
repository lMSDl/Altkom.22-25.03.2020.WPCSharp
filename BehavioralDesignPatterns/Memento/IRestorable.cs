﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Memento
{
    public interface IRestorable<T>
    {
        void Restore(T state);
    }
}
