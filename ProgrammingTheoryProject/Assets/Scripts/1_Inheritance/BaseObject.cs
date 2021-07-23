using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// This is a BaseObject class. It too inherits from MonoBehaviour
/// 
/// In this class you can place properties and methods that can be shared to everyone that
/// Inherits from it.
/// 
/// In this example the keyword abstract is used, to force this class to be inherited by another,
/// meaning you cannot use it directly.
/// 
/// </summary>
public abstract class BaseObject : MonoBehaviour
{
    // Below properties are exposed to the inherited class
    public string baseClassStringProperty;
    public int baseClassIntProperty;

    // Below properties are kept internal
    private string baseClassStringInternalProperty;
    private int baseClassIntInternalProperty;

    // Method can be called from the inheriting class
    public void PrintBaseValues()
    {
        Debug.Log($"baseStringValue: {baseClassStringProperty}");

    }
}
