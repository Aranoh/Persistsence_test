using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using xmlSpace;

public class DerivedClass : MonoBehaviour, ITop, IBase,IDerived
{
    private XmlFieldsDerived derivedXML;
    public XmlFieldsDerived xmlFieldDerived { get => derivedXML as XmlFieldsDerived; set => throw new System.NotImplementedException(); }
    public XmlFieldsTop xmlFieldTop { get => derivedXML as XmlFieldsTop; set => throw new System.NotImplementedException(); }
    public XmlFieldsBase xmlFieldBase { get => derivedXML as XmlFieldsBase; set => throw new System.NotImplementedException(); }

    void function()
    {
        //being able to access fields from here to top using the serializable XML classes
        //string somestring = Serializable.BaseStringField + Serializable.DerivedStringField + Serializable.TopStringField;

        //had to be rewritten
        string somestring = xmlFieldTop.TopStringField = xmlFieldBase.TopStringField + xmlFieldDerived.DerivedStringField;
    }
}

