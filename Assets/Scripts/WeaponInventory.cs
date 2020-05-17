using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponInventory : MonoBehaviour
{

    public GameObject[] weapons; // 

    public int currentWeapon = 0;

    public static int nrWeapons; //Static variable that holds the number of weapons inventory is capable of holding

    void Start()
    {

        nrWeapons = weapons.Length;

        SwitchWeapon(currentWeapon); // change gun display

    }

    void Update()
    {
        ObjectCollision playerInv = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjectCollision>(); //creating a reference to the current players object so we can check the weapon status

        for (int i = 1; i <= nrWeapons; i++) //checks every possible user input depending on how many weapons are in the inventory
        {
            if (Input.GetKeyDown("" + i)) //checking the status of whether the weapon status is active or not, so if the player has not picked up the rifle (in the games case), then it wont switch to it until the player picks it up
            {
                if (playerInv.activeWeapons[i-1] == true)
                {
                    currentWeapon = i - 1;

                    SwitchWeapon(currentWeapon);
                } 
            }
        }

    }

    void SwitchWeapon(int index) //enables or disables weapons depending on the one the player chooses from the array
    {

        for (int i = 0; i < nrWeapons; i++)
        {
            if (i == index)
            {
                weapons[i].gameObject.SetActive(true);
            }
            else
            {
                weapons[i].gameObject.SetActive(false);
            }
        }
    }

}

