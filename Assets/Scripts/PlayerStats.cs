using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerStats : MonoBehaviour
{
    public string playerName;
    
    public int playerHealth;
    public int playerScore;

    public float playerSpeed;

    public bool isGameOver;
    void Start()
    {
        isGameOver = false;
        //PrintStats();
    }

    void Update()
    {
        if (isGameOver)
        {
            return;
        }
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            playerHealth -= 25;
            PrintStats();
        }
        else if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            playerHealth += 25;
            PrintStats();
        }

        if (playerHealth <= 0)
        {
            isGameOver = true;
            Debug.Log("Game Over:(");
        }
    }

    public void PrintStats()
    { 
        Debug.Log(playerName + " has " + playerHealth + " health and " + playerScore + " score.");        
    }
}
