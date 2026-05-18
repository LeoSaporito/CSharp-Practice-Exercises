using UnityEngine;
using UnityEngine.InputSystem;

public class Arrays : MonoBehaviour
{
    public int[] nums = new int[5];
    
    void Start()
    {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = Random.Range(0, 20);        
        }
    }

    void Update()
    {
        if (Keyboard.current.uKey.wasPressedThisFrame)
        {
            PrintNums();
        }

        if (Keyboard.current.iKey.wasPressedThisFrame)
        {
            ComparingNums();
        }

        if (Keyboard.current.oKey.wasPressedThisFrame)
        {
            FindingTheAverage();
        }

        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            PrintArrayBackward();
        }
    }

    public void PrintNums()
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Debug.Log(nums[i]);            
        }
    }

    public void ComparingNums()
    {
        int largestNum = nums[0];
        
        for (int i = 0; i < nums.Length; i++)
        {            
            if (nums[i] > largestNum)
            {
                largestNum = nums[i];
            }
        }

        Debug.Log(largestNum);
    }

    public void FindingTheAverage()
    {
        int sum = nums[0];
        
        for (int i = 1; i < nums.Length; i++)
        { 
            sum += nums[i];           
        }

        int average = sum / nums.Length;

        Debug.Log(average);
    }

    public void PrintArrayBackward()
    {
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            Debug.Log(nums[i]);
        }
    }
}
