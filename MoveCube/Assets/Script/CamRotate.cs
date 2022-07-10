using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    //Vector2 turn;
    public float speed = 4.0f;
    float xRotate = 0.0f;
    public float minRotate = -45.0f;
    public float maxRotate = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            xRotate += Input.GetAxis("Mouse X") * speed;
            xRotate = Mathf.Clamp(xRotate, minRotate, maxRotate);
            transform.eulerAngles = new Vector3(0, -xRotate, 0);
        }
        //    turn.x += Input.GetAxis("Mouse X");
        //    //turn.y += Input.GetAxis("Mouse Y");
        //    //transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        //    transform.localRotation = Quaternion.Euler(0, turn.x, 0);
    }
}
