using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ammo")
        {
            Destroy(other.gameObject);
            PlayerStats.playerAmmo += 5;
        }
        if (other.gameObject.tag == "Health")
        {
            Destroy(other.gameObject);
            PlayerStats.playerHealth += 2;
        }
        if (other.gameObject.tag == "Armor")
        {
            Destroy(other.gameObject);
            PlayerStats.playerArmor += 10;
        }
    }
}
