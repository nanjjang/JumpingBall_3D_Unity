using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

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
    int jump_num = 0;
    public SoundManger sound;
    public SceneManger scene;

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
                rb.AddForce(Vector3.up * 4300);
                jump_num++;
                sound.GetComponent<SoundManger>().Play("jumping");
            }
            if(jump_num >= 2)
            {
                jumping = true;
                jump_num = 0;
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
            sound.GetComponent<SoundManger>().Play("landing");
        }
        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            rb.AddForce(Vector3.back * 900, ForceMode.Impulse);
            sound.GetComponent<SoundManger>().Play("Obs");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish")
        {
            SceneManager.LoadScene("Ingame2");

        }
        if (other.tag == "The_End") 
        {
            scene.GetComponent<SceneManger>().exit();
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
        transform.position = SpawnPoint.position;
    }
}