﻿using System.ComponentModel;

namespace UciEngineLib.Events
{
    public enum OptionEventFieldType
    {
        [Description("name")]
        Name,

        [Description("type")]
        Type,

        [Description("default")]
        Default,

        [Description("min")]
        Min,

        [Description("max")]
        Max,

        [Description("var")]
        Var
    }
}
