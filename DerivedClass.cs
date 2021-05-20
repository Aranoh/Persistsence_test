using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fieldsNamespace;

public class DerivedClass : BaseClass
{
    public new FieldsDerived Serializable
    {
        get => _serializable as FieldsDerived;
        set => _serializable = value as FieldsDerived;
    }

    public override void print()
    {
        //base.print();
        Debug.Log($" Deriv: {Serializable.BaseStringField}");
        Debug.Log($" Deriv: {Serializable.DerivedStringField}");
    }

    protected override void Awake()
    {
        _serializable = new FieldsDerived();
        Serializable.BaseStringField = "test";
        Debug.Log(this.gameObject.name);
        print();
        base.print();

    }
}

