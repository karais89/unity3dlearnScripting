using UnityEngine;
using System.Collections;

namespace exam_4
{
    public class ExampleSyntax : MonoBehaviour {

    int myInt = 5;
    
    int MyFunction (int number)
    {
        int ret = myInt * number;
        return ret;
    }
    }    
}
