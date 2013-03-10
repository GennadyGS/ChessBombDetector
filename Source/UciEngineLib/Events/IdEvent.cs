﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBombDetector.EventFields;

namespace ChessBombDetector.Events
{
    internal class IdEvent : ComplexEvent<IdEventFieldId>
    {
        private static void RegisterFields()
        {
            RegisterField<StringEventField>(IdEventFieldId.Name,
                                               (data, field) => ((IdEvent) data).Name = field);
            RegisterField<StringEventField>(IdEventFieldId.Author,
                                               (data, field) => ((IdEvent) data).Author = field);
        }

        static IdEvent()
        {
            RegisterFields();
        }

        public StringEventField Name { get; private set; }
        public StringEventField Author { get; private set; }

        public IdEvent() : base(EventType.Id) {}
    }
}