using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallMoving : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    Rigidbody rb;
    float mouseX = 0.0f;
    public float speed;
    public float superSpeed;
    Vector3 move;
    public float senstivity = 5.0f;
    bool jumping = false;
    public Transform SpawnPoint;
    public GameObject Player;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (jumping == false)
            {
                rb.AddForce(Vector3.up * 4000);
                jumping = true;
                Debug.Log(jumping);
            }
        }

        Vector3 moveDirection = transform.forward * vertical() + transform.right * horizontal();
        moveDirection.Normalize(); // 이동 방향을 정규화
        rb.AddForce(moveDirection * speed, ForceMode.Impulse);
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(moveDirection * superSpeed, ForceMode.Impulse);
        }

        mouseX += Input.GetAxis("Mouse X") * senstivity;

        Vector3 angle = new Vector3(0, mouseX, 0);
        Angle(angle);

        if (transform.position.y < -10)
        {
            Respawn();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor")){
            jumping = false;
            Debug.Log(jumping);
        }
        
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            rb.AddForce(Vector3.back * 900, ForceMode.Impulse);
        }
    }


    float horizontal()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        return horizontalInput;
    }
    float vertical()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
        return verticalInput;
    }
    void Angle(Vector3 angle)
    {
        transform.rotation = Quaternion.Euler(angle);
    }
    void Respawn()
    {
        Player.transform.position = SpawnPoint.position;
    }
}