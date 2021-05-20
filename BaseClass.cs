using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fieldsNamespace;


public class BaseClass : MonoBehaviour
{
    [SerializeField]
    protected FieldsBase _serializable;

    public FieldsBase Serializable
    {
        get => _serializable;
        set => _serializable = value;
    }

    public virtual void print()
    {
        Debug.Log($"Base: {_serializable.BaseStringField}");
    }

    protected virtual void Awake()
    {
        _serializable = new FieldsBase();
        Debug.Log(this.gameObject.name);
        print();
    }
}
