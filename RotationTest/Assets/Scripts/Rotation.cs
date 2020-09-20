using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float RotateSpeed = 30f;
   
    void Update () {
        if (Input.GetAxisRaw("Horizontal") == 1)
            transform.Rotate(Vector3.forward * RotateSpeed * Time. deltaTime);
        else if (Input.GetAxisRaw("Horizontal") == -1)
            transform.Rotate(Vector3.back * RotateSpeed * Time.deltaTime);
    }

    

}
