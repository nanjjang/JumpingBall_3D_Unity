using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoving : MonoBehaviour
{
    float h;
    float v;
    Rigidbody rb;
    float JumpingPower = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        Vector3 move = new Vector3(h, 0, v);

        if (Input.GetButtonDown("Jump"))
        {
            move = new Vector3(0, JumpingPower, 0);
        }
    }
}
