using UnityEngine;
using System.Collections;
namespace Exam_12
{
    public class CheckState : MonoBehaviour 
    {
        public GameObject myObject;        
        
        void Start ()
        {
            Debug.Log("Active Self: " + myObject.activeSelf);
            Debug.Log("Active in Hierarchy: " + myObject.activeInHierarchy);
        }
    }
}
