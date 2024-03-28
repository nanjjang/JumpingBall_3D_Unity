using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour
{
    public float rotateSpeed;
    public int itemCount;
    AudioSource audio;
    public GameManager manager;
    // Update is called once per frame
    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            itemCount++;
            manager.GetItem(itemCount);
            audio.Play();
            transform.gameObject.SetActive(false);
            Debug.Log(itemCount);
        }
    }
}