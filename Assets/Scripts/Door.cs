using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isOpen = false;
    public Animator doorAnimation;
    public GameObject door1;
    public GameObject door2;
    public GameObject secretDoor;
    public ObjectCollision checkingKey; //references the script ObjectCollision

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOpen)
        {
            doorAnimation.Play("Dooranim");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Door")) //sets the isOpen variable true so the player can open it in update by pressing a key
        {
            isOpen = true;
        }

        if (other.gameObject.CompareTag("Door1") && checkingKey.keyCheck1 == true) //only opens this door if the key is in players inventory
        {
            Destroy(door1.gameObject);
        }

        if (other.gameObject.CompareTag("Secret")) //opend the door if the player gets in the collider
        {
            Destroy(secretDoor.gameObject);
        }

        if (other.gameObject.CompareTag("Door2") && checkingKey.keyCheck2 == true) //only opens this door if the key needed is in players inventory
        {
            Destroy(door2.gameObject);
        }
    }

}
