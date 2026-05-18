using UnityEngine;
using UnityEngine.InputSystem;

public class DictionaryPractice : MonoBehaviour
{
    public string potion = "Potion";
    public string sword = "Sword";

    public int addMoney;

    void Start()
    {
        
    }

    void Update()
    {
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            DisplayPrice();
        }
        if (Keyboard.current.nKey.wasPressedThisFrame)
        {
            IncreaseMoney();
        }
        if (Keyboard.current.bKey.wasPressedThisFrame)
        {
            PurchaseCheck();
        }
    }

    public void DisplayPrice()
    {
        Debug.Log("Potion : $10");
        Debug.Log("Sword : $50");
    }
    public void IncreaseMoney()
    {
        addMoney += 5;
    }
    public void PurchaseCheck()
    {
        if (addMoney >= 50)
        {
            Debug.Log("You can buy a sword and potions");
        }
        else if (addMoney >= 10)
        {
            Debug.Log("You can buy potions");
        }
        else 
        {
            Debug.Log("You're Broke :(");
        }
    }
}
