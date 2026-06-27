using UnityEngine;

public class GhostDamage : MonoBehaviour
{
    public int damage = 1;
    public float damageCooldown = 1f;

    private float lastDamageTime;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Time.time - lastDamageTime >= damageCooldown)
            {
                collision.GetComponent<PlayerHealth>().TakeDamage(damage);
                lastDamageTime = Time.time;
            }
        }
    }
}