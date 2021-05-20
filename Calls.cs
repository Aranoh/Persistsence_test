using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using xmlSpace;


public class Calls : MonoBehaviour
{
    //calls are made to the scripts to hopefully expose them to the persistent classes window.
    public ClassUsingGeneric<string> generic;
    public XmlFieldsDerived derivXML;
    public XmlFieldsBase baseXml;
    // DerivedClass<XmlFieldsDerived> deriv;

    public BaseClass bbase;
    public DerivedClass deriv;


}
