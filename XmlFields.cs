using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace xmlSpace
{
    public class XmlFieldsTop
    {
        public string TopStringField;
        public int TopIntField;
    }
    public class XmlFieldsBase : XmlFieldsTop
    {
        public string BaseStringField;
        public int BaseIntField;
    }

    public class XmlFieldsDerived : XmlFieldsBase
    {
        public string DerivedStringField;
        public int DerivedIntField;
    }
}

