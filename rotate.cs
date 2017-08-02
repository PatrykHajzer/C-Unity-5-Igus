using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * 1.0F;
        

        transform.RotateAround(Vector3.up, -rotX);
        
    }
}
