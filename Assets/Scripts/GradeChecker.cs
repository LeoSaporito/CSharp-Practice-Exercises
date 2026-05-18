using UnityEngine;
using UnityEngine.InputSystem;

public class GradeChecker : MonoBehaviour
{
    public int gradeNumber;
    public string gradeString;
    void Start()
    {
        
    }

    void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            GradeText();
        }
    }

    public void GradeText()
    {
        GradeGenerator();
        Debug.Log("Your grade: " + gradeString);
    }
    public void GradeGenerator()
    {
        gradeNumber = Random.Range(0, 100);

        if (gradeNumber > 89)
        {
            gradeString = "A+";
        }
        if (gradeNumber > 79 && gradeNumber < 90)
        {
            gradeString = "A";
        }
        if (gradeNumber > 69 && gradeNumber < 80)
        {
            gradeString = "B";
        }
        if (gradeNumber > 59 && gradeNumber < 70)
        {
            gradeString = "C";
        }
        if (gradeNumber > 49 && gradeNumber < 60)
        {
            gradeString = "D";
        }
        if (gradeNumber < 50)
        {
            gradeString = "F";
        }
    }    
}
