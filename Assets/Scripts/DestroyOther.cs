using UnityEngine;
using System.Collections;

public class DestroyOther : MonoBehaviour 
{
	public GameObject other;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}
