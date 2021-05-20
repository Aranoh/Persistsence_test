using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using xmlSpace;


public class BaseClass<T> : MonoBehaviour, Iinterface<T> where T : XmlFieldsBase
{
    private T _serializable;
    public T Serializable { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

}
