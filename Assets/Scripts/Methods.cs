using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Methods : MonoBehaviour
{
    public int aValue;
    public int bValue;

    public int healthValue;
    public int damageValue;

    public int[] nums = new int[5];

    void Start()
    {
        
    }

    void Update()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            aValue = AddNumbers(aValue, bValue);

            Debug.Log(aValue);
        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            healthValue = TakeDamage(healthValue, damageValue);

            Debug.Log(healthValue);
        }

        if (Keyboard.current.dKey.wasPressedThisFrame)
        {                                
            IsEven(Random.Range(0, 15));
        }

        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Random.Range(0, 10);
            }

            GetArrayTotal(nums);
        }
    }

    public int AddNumbers(int a, int b)
    {
        a += b;

        return a;
    }

    public int TakeDamage(int health, int damage)
    { 
        int remainingHealth = health - damage;

        return remainingHealth;
    }

    public void IsEven(int number)
    {
        if (number % 2 == 0)
        {
            Debug.Log(number + " is even.");
        }
        else
        {
            Debug.Log(number + " is not even");
        }
    }

    public void GetArrayTotal(int[] numbers)
    {
        int sum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            sum += nums[i];    
        }

        Debug.Log(sum); 
    }
}
