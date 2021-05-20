using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using xmlSpace;


public class BaseClass : MonoBehaviour
{
    public FieldsBase fieldsBase;
    public virtual void print()
    {
        Debug.Log($"Base: {fieldsBase.BaseStringField}");
    }

}
