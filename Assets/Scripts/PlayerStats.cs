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
        //initializes the players stats
        playerHealth = 100;
        playerAmmo = 0;
        playerArmor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //displays the players stats
        ammoDisplay.GetComponent <Text>().text = "" + playerAmmo;
        healthDisplay.GetComponent<Text>().text = "" + playerHealth + "%";
        armorDisplay.GetComponent<Text>().text = "" + playerArmor + "%";
        CheckHealth();
    }

    void CheckHealth()
    {
        if(playerHealth <= 0) //when players health reaches zero, the player goes to the lose scene
        {
            SceneManager.LoadScene(1);
        }
    }


}
