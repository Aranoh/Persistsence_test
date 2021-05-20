using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fieldsNamespace;


public class Calls : MonoBehaviour
{
    public void Start()
    {
        DerivedClass testDeriv = new DerivedClass();
        testDeriv.print();
        FieldsDerived fields = new FieldsDerived();
        fields.BaseStringField = "base";
        fields.DerivedStringField = "Deriv";
        fields.TopStringField = "Top";
        testDeriv.Serializable = fields;
    }

}
