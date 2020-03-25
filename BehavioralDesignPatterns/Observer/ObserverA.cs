﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer
{
    public class ObserverA : Observer<int>
    {
        public override void OnNext(int value)
        {
            if(value < 3)
                Console.WriteLine("ObserverA: EVENT! " + value);
        }
    }
}
