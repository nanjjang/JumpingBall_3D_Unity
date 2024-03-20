using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoving : MonoBehaviour
{
    float h;
    float v;
    Rigidbody rb;
    float mouseX = 0.0f;
    public float jumpingPower = 250.0f;
    public float speed;
    public float superSpeed;
    Vector3 move;
    public float senstivity = 5.0f;
    bool jumping = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        
        
        if (Input.GetButtonDown("Jump") && !jumping)
        {
            rb.AddForce(Vector3.up * 250);
            jumping = true;
        }
        

        Vector3 forwardDirection=transform.forward;
        forwardDirection.y = 0;
        move = new Vector3(h, 0, v);
        move = Quaternion.LookRotation(forwardDirection) * move;
        transform.position += move * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += move * superSpeed * Time.deltaTime;
        }

        mouseX += Input.GetAxis("Mouse X") * senstivity;

        Vector3 angle = new Vector3(0, mouseX, 0);
        transform.rotation=Quaternion.Euler(angle);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor")){
            jumping = false;
        }
    }
}
