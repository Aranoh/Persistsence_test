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
        Debug.Log($"Deriv go: {this.gameObject.name}");
        Debug.Log($"Deriv bs: {Serializable.BaseStringField}");
        Debug.Log($"Deriv ds: {Serializable.DerivedStringField}");
        base.print();
    }

    protected override void Awake()
    {        
        if (_serializable == null) 
            _serializable = new FieldsDerived();
    }

    private void Update()
    {
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Serializable.BaseStringField = Random.Range(0, 100).ToString();
                Serializable.DerivedStringField = Random.Range(0, 100).ToString();

            }
        }
    }
}

