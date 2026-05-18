using UnityEngine;
using UnityEngine.InputSystem;

public class Strings : MonoBehaviour
{
    public string playerName;

    void Start()
    {
        
    }

    void Update()
    {
        if (Keyboard.current.jKey.wasPressedThisFrame)
        {
            StringLength();   
        }

        if (Keyboard.current.kKey.wasPressedThisFrame)
        {
            VowelsInString();
        }

        if (Keyboard.current.lKey.wasPressedThisFrame)
        {
            ReverseString();
        }
    }

    public void StringLength()
    {
        int stringLength = playerName.Length;

        Debug.Log(stringLength);
    }

    public void VowelsInString()
    {
        int vowelCount = 0;

        for (int i = 0; i < playerName.Length; i++)
        {
            char currentLetter = playerName[i];

            if (currentLetter == 'a' ||
                currentLetter == 'e' ||
                currentLetter == 'i' ||
                currentLetter == 'o' ||
                currentLetter == 'u')
            {
                vowelCount++;
            }
        }

        Debug.Log(vowelCount);
    }

    public void ReverseString()
    { 
        
    }
}
