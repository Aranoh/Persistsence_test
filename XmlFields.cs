using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace xmlSpace
{
    public class FieldsTop
    {
        public string TopStringField = "top";
    }
    public class FieldsBase : FieldsTop
    {
        public string BaseStringField = "base";
    }

    public class FieldsDerived : FieldsBase
    {
        public string DerivedStringField = "derived";
    }
}

