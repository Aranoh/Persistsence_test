using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using xmlSpace;

public class DerivedClass<T> : BaseClass<T> where T : XmlFieldsDerived, new()
{
    void function()
    {
        //being able to access fields from here to top using the serializable XML classes
        string somestring = Serializable.BaseStringField + Serializable.DerivedStringField + Serializable.TopStringField;
    }
}

