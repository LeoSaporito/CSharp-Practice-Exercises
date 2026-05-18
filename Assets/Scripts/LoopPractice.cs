using UnityEngine;
using UnityEngine.InputSystem;

public class LoopPractice : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            OneToTen();
        }

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Countdown();
        }

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            AddOneToOneHundred();
        }
    }

    public void OneToTen()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(i);
        }
    }

    public void Countdown()
    {
        for (int i = 3; i > 0; i--)
        {
            Debug.Log(i);

            if (i == 1)
            {
                Debug.Log("GO!");
            }
        }
    }

    public void AddOneToOneHundred() //???
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log(i += i);
        }
    }
}
