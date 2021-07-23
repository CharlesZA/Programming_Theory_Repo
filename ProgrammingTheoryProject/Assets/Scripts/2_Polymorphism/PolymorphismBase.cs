using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This is a Base class. It too inherits from MonoBehaviour
/// 
/// In this class you can place properties and methods that can be shared to everyone that
/// Inherits from it.
/// 
/// In this example the keyword abstract is used, to force this class to be inherited by another,
/// meaning you cannot use it directly.
/// 
/// </summary>

public abstract class PolymorphismBase : MonoBehaviour
{

    public string basePolyStyle = "Base poly style";

    public void DoSomething()
    {
        Debug.Log("Something is done here");
    }

}
