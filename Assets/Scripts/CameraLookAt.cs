using UnityEngine;using System.Collections;namespace Exam_14
{
    public class CameraLookAt : MonoBehaviour
    {
        public Transform target;

        void Update()
        {
            transform.LookAt(target);
        }
    }
}