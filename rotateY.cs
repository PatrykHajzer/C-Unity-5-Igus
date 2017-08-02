using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateY : MonoBehaviour
{
    public Quaternion from = Quaternion.Euler(0, 0, 0);
    public Quaternion to = Quaternion.Euler(new Vector3(180, 0, 0));

    void OnMouseDrag()
    {
        float rotY = Input.GetAxis("Mouse Y") * 0.1F;
        transform.rotation = Quaternion.Slerp(from, to, Time.time * 0.1F);
        
    }
}