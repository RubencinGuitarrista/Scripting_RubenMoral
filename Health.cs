using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    //Current player health
    public int currentHealth = 10;

    //Max player health
    public int maxHealth = 10;

    //The component responsible for playing sounds
    public AudioSource audioSource;
 
    //Sound file containing the damage sound effect
    public AudioClip damageSound;

    //The method that processes the damage done
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
 
        // If there is still health, then the sound of damage is played
        if(currentHealth > 0)
        {
            audioSource.PlayOneShot(damageSound);
            //print("Player health: " + health);
        }
        //If there is no health, then the current scene is restarted
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
 
}