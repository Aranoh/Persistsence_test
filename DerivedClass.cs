using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using xmlSpace;

public class DerivedClass : BaseClass
{
    public FieldsDerived fieldsDerived;

    public override void print()
    {
        //base.print();
        Debug.Log($" Deriv: {fieldsDerived.DerivedStringField}");
        Debug.Log($" Deriv: {fieldsDerived.BaseStringField}");
    }
    void function()
    {
        //being able to access fields from here to top using the serializable XML classes
        //string somestring = Serializable.BaseStringField + Serializable.DerivedStringField;
        //+ Serializable.TopStringField;
    }
}

