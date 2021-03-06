﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using Maileon.Utils;

namespace Maileon.Contacts
{
    /// <summary>
    /// A class for wrapping custom fields
    /// </summary>
    public class CustomField
    {
        /// <summary>
        /// The name of this custom field
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
        /// <summary>
        /// The value of this custom field
        /// </summary>
        [XmlElement("value")]
        public NullableValue<string> Value { get; set; }

        public CustomField(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        public CustomField() { }
    }
}
