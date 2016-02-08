using UnityEngine;
using System.Collections;
namespace exam_03
{
    public class BasicSyntax : MonoBehaviour 
    {        
        // Use this for initialization
        void Start () 
        {
            // This line is there to tell me the X Postion of my object
            
            /*
            Hi there!
            This is Two lines!
            */
            
            Debug.Log(transform.position.x);
            
            /*
            if(transform.position.y <= 5f)
            {
                Debug.Log("I`m about to hit the ground!");
            }
            */
        }
    }    
}
