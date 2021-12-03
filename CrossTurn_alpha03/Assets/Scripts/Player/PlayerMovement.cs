using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float rotationSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void RotatePlayer()
    {
        float dir = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, rotationSpeed * -dir * Time.deltaTime);

    }
    void FixedUpdate() 
    {
        RotatePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
