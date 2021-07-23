using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Encapsulation is the form of protecting the data in the class, so that you have predicted results.
/// 
/// Coding with a defensive mindset.
/// 
/// Note: While defensive mindset is good, having a test project with Asserts can help you test quality.
///       
/// </summary>



/// Namespace added to group the usage of the class
namespace MyEncapsulatedNamespace
{

    public class EncapsulationExampleClass : MonoBehaviour
    {

        /// <summary>
        /// Below is an example of a property with a backing field.
        /// 
        /// </summary>
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set 
            { 
                // Place code here to do any validation checks on the data received.
                myVar = value; 
            }
        }


        public void MyMethod(int parameter)
        {
            // Check the parameters for example
            if (parameter < 0)
            {
                throw new System.ArgumentException("integer cannot be less than zero","parameter");
            }



            // Then do the actual code
        }


    }

}
