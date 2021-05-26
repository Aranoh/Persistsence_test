using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fieldsNamespace;


public class BaseClass : MonoBehaviour
{
    //[SerializeField]
    protected FieldsBase _serializable;

    public FieldsBase Serializable
    {
        get => _serializable;
        set => _serializable = value;
    }

    public virtual void print()
    {
        Debug.Log($"Base go: {this.gameObject.name}");
        Debug.Log($"Base bs: {_serializable.BaseStringField}");
    }

    protected virtual void Awake()
    {
        if (_serializable == null)
            _serializable = new FieldsDerived();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Serializable.BaseStringField = Random.Range(0, 100).ToString();
            }
        }
    }
}
