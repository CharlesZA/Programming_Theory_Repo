using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This inherited class add a new function 'DoSomething' that is similiar
/// </summary>
public class PolymorphismInherited : PolymorphismBase
{


    /// <summary>
    /// Below is a method that some something special.
    /// It has the same name, but with a parameter.
    /// </summary>
    /// <param name="somethingWithInt"></param>
    public void DoSomething(int somethingWithInt)
    {
        Debug.Log($"Something is done here with integer {somethingWithInt}");

        // If you need to call the base function you'll need to add it like below
        base.DoSomething();
    }

    private void Start()
    {
        // Calling polymophed methods
        DoSomething();  // This one is from the base
        DoSomething(5); // This is from the function defined in this class
    }

}
