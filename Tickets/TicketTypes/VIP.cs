﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.TicketTypes
{
    public class VIP : TicketDispenser
    {
        public override int Price { get; } = 220;
    }
}