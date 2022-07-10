using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed = 2.0f;

    private void Update()
    {
        float xRotate = Input.GetAxis("Mouse X");
        float yRotate = Input.GetAxis("Mouse Y");
        if (Input.GetMouseButton(0))
        {
            transform.position += speed * new Vector3(xRotate,0,yRotate);
 
        }
    }
}
