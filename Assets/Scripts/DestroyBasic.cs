using UnityEngine;
using System.Collections;

public class DestroyBasic : MonoBehaviour 
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
