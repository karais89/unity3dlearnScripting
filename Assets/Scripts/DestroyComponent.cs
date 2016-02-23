using UnityEngine;
using System.Collections;

public class DestroyComponent : MonoBehaviour 
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
