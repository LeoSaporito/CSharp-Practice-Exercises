using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Modulus : MonoBehaviour
{
    public int randomNumber;
    void Start()
    {
        
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GenerateRandomNumber();
        }
    }

    public void GenerateRandomNumber()
    {        
        randomNumber = Random.Range(0, 10);

        if (randomNumber % 2 == 0)
        {
            Debug.Log(randomNumber + " is an even number.");
        }
        else 
        {
            Debug.Log(randomNumber + " is NOT an even number.");
        }

    }
}
