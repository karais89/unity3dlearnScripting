using UnityEngine;
using System.Collections;

namespace exam_02 {
	public class VariablesAndFunctions : MonoBehaviour {

		int myInt = 5;

		void Start() {
			myInt = MultiplyByTwo(myInt);
            Debug.Log(myInt);
		}
        
        // 함수 선언
        int MultiplyByTwo(int number)
        {
            int ret;
            
            ret = number * 2;
            
            return ret;        
        }
	}
}
