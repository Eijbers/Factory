﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Factory.Models.Interfaces;

namespace Factory.Factory.Models.Factory
{
    internal class RoadLogistics : Logistics
    {
        public override ITransport createTransport()
        {
            return new Truck();
        }
    }
}
