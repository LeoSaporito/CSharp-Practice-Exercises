using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class DictionaryPractice : MonoBehaviour
{
    Dictionary<string, int> itemPrices = new Dictionary<string, int>();

    public int addMoney;

    void Start()
    {
        itemPrices.Add("Sword", 50);
        itemPrices.Add("Potion", 10);
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
        Debug.Log(itemPrices["Potion"]);            
        Debug.Log(itemPrices["Sword"]);                    
    }
    public void IncreaseMoney()
    {
        addMoney += 5;
    }
    public void PurchaseCheck()
    {        
        if (addMoney >= itemPrices["Sword"])
        {
            Debug.Log("You can buy a sword");
        }    
        if (addMoney >= itemPrices["Potion"])
        {
            Debug.Log("You can buy potions");
        }
        else 
        {
            Debug.Log("You're Broke :(");
        }
    }
}
