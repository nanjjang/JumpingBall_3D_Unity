using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour
{
    public float rotateSpeed;
    public int itemCount;
    public SoundManger sound;
    public ScoreManger score;
    
    void Update()
    {
        transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
    }
    

    void OnTriggerEnter(Collider other)
    {   
        switch (other.tag)
        {
            case "Player":
                transform.gameObject.SetActive(false);
                sound.GetComponent<SoundManger>().Play("getitem");
                score.GetComponent<ScoreManger>().Score();
                break;
        }
    }
}