using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using xmlSpace;


public class BaseClass : MonoBehaviour, IBase, ITop
{
   
    public XmlFieldsTop xmlFieldTop { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public XmlFieldsBase xmlFieldBase { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
}
