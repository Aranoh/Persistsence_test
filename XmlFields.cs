using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace fieldsNamespace
{
    [Serializable]
    public class FieldsBase
    {
        public string BaseStringField = "base";
    }
    [Serializable]
    public class FieldsDerived : FieldsBase
    {
        public string DerivedStringField = "derived";
    }
}

