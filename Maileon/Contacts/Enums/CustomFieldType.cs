﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace Maileon.Contacts
{
    public enum CustomFieldType
    {
        [XmlEnum("string")]
        String,
        [XmlEnum("integer")]
        Integer,
        [XmlEnum("boolean")]
        Boolean,
        [XmlEnum("float")]
        Float,
        [XmlEnum("double")]
        Double,
        [XmlEnum("date")]
        Date
    }
}
