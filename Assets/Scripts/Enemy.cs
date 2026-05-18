using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour
{
    public string enemyName = "Alf";
    public int health;
    public int damage;

    public GameObject enemyPrefab;
    public Vector2 enemyPosition;

    void Start()
    {
        Instantiate(enemyPrefab, enemyPosition, Quaternion.identity);

        Debug.Log(enemyName + " : " + health);
    }

    void Update()
    {
        Vector2 currentMousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        float distance = Vector2.Distance(currentMousePosition, enemyPosition);

        if (distance < 1 && Mouse.current.leftButton.wasPressedThisFrame)
        {
            health -= damage;

            Debug.Log(enemyName + " : " + health);
        }
    }
}
