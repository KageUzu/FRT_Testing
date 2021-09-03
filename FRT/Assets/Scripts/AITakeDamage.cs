using UnityEngine;

public class AITakeDamage : MonoBehaviour
{
    private int health = 100;

    void TakeDamage(int damageAmount)
    {
        health = health - damageAmount;
        Debug.Log("DamageTaken");

        if (health < 0)
        {
            Debug.Log("Dead!");
        }

    }
}
