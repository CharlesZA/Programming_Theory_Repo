using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This class shows an example of Abstration.
/// 
/// Refactoring code is important for when you or another persons looks at code 6 months later and you're still able to determine what is going on.
/// 
/// It is import also to remain consist in your coding style as this helps with abstraction readability.
/// 
/// </summary>

public class AbstractionSample : MonoBehaviour
{

    // Unrefacoted Method
    // All code is just put into a single monolithic method.
    private void UnrefactoredMethod()
    {
        // Some code ...
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");


        // Some code....
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");


        // Some code...
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
    }


    // Refactored Method
    // Code is refactored into methods of functionality.
    private void RefactoredMethod()
    {
        // Some code ...
        SomeCode1();


        // Some code....
        SomeCode2();


        // Some code...
        SomeCode3();

    }

    private static void SomeCode3()
    {
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
    }

    private static void SomeCode2()
    {
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
    }

    private static void SomeCode1()
    {
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
        Debug.Log("Some code");
    }
}
