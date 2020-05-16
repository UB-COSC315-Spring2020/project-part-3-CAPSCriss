using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour
{
    public Text ammoDisplay;
    public static int playerAmmo;
    public Text healthDisplay;
    public static int playerHealth;
    public Text armorDisplay;
    public static int playerArmor;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
        playerAmmo = 0;
        playerArmor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ammoDisplay.GetComponent <Text>().text = "" + playerAmmo;
        healthDisplay.GetComponent<Text>().text = "" + playerHealth + "%";
        armorDisplay.GetComponent<Text>().text = "" + playerArmor + "%";
        CheckHealth();
    }

    void CheckHealth()
    {
        if(playerHealth <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }


}
