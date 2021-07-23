using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This class inherits from BaseObject.
/// 
/// It can use the properties and methods of the BaseObject, as well as have its own to make it unique
/// </summary>

public class MyInheritedObject1 : BaseObject
{

    // My unique properties
    public string aCoolPropertyValue = "This comes from the inherited class";


    // Start is called before the first frame update
    void Start()
    {
        // Calling properties and methods from the base.
        // This the below code you can choose the use the base keyword to access properties and methods.
        base.baseClassIntProperty = 1;
        baseClassStringProperty = "Hello base";

        base.PrintBaseValues();
    }

}
