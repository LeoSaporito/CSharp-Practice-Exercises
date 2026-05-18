using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class ListPractice : MonoBehaviour
{
    public List<string> inventory = new List<string>();

    void Start()
    {
        
    }

    void Update()
    {
        if (Keyboard.current.zKey.wasPressedThisFrame)
        {
            AddPotion();
        }

        if (Keyboard.current.xKey.wasPressedThisFrame)
        {
            AddKey();
        }

        if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            PrintList();
        }
        if (Keyboard.current.vKey.wasPressedThisFrame)
        {
            RemovePotion();
        }
    }

    public void AddPotion()
    {
        inventory.Add("Potion");
    }
    public void AddKey()
    {
        inventory.Add("Key");
    }
    public void PrintList()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            Debug.Log(inventory[i]);
        }
    }

    public void RemovePotion()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i] == "Potion")
            { 
                inventory.RemoveAt(i);        
            }
        }
    }
}
