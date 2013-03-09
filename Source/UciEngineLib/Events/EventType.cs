﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBombDetector.Events
{
    enum EventType
    {
        [Description("id")]
        Id,

        [Description("ok")]
        UciOk,

        [Description("readyok")]
        ReadyOk,

        [Description("bestmove")]
        BestMove,

        [Description("copyprotection")]
        CopyProtection,

        [Description("registration")]
        Registration,

        [Description("info")]
        Info,

        [Description("option")]
        Option
    }
}
