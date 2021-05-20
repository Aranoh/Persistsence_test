using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerivedClass<T> : BaseClass<T> where T : XmlFieldsDerived, new()
{
    void function()
    {
        string somestring = Serializable.BaseStringField + Serializable.DerivedStringField;
    }
}

