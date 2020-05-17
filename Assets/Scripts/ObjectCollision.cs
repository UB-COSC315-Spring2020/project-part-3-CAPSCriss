using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectCollision : MonoBehaviour
{
    public bool[] activeWeapons = new bool[WeaponInventory.nrWeapons]; //boolean array of active weapons mirroring inventory
    public bool keyCheck1 = false;
    public bool keyCheck2 = false;
    public GameObject rifleImage;
    public GameObject key1Image;
    public GameObject key2Image;

    public void Start()
    {
        rifleImage.SetActive(false);
        activeWeapons[0] = true;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ammo") //Ammo pickup
        {
            Destroy(other.gameObject);
            PlayerStats.playerAmmo += 10;
        }
        if (other.gameObject.tag == "Health") //Health pickup
        {
            Destroy(other.gameObject);
            PlayerStats.playerHealth += 20;
        }
        if (other.gameObject.tag == "Armor") //Armor pickup
        {
            Destroy(other.gameObject);
            PlayerStats.playerArmor += 10;
        }

        if (other.gameObject.tag == "Rifle") //Weapon pickup
        {
            Destroy(other.gameObject);
            activeWeapons[1] = true; //makes it true so it can be referenced on the weaponinventory script
            rifleImage.SetActive(true); //makes it appear in players inventory
        }

        if (other.gameObject.tag == "Key1") //Key pickup
        {
            Destroy(other.gameObject);
            key1Image.SetActive(true); //makes it appear in players inventory
            keyCheck1 = true; //change of boolean to be able to open the doors
        }

        if (other.gameObject.tag == "Key2") //Key pickup
        {
            Destroy(other.gameObject);
            key2Image.SetActive(true); //makes it appear in players inventory
            keyCheck2 = true; //change of boolean to be able to open the doors
        }

        if (other.gameObject.tag == "Win")
        {
            SceneManager.LoadScene(2);
        }
    }
}
