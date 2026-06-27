using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    public TextMeshProUGUI healthText;

    private bool isDead = false;

    void Start()
    {
        UpdateHealthUI();
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        health -= damage;
        UpdateHealthUI();

        if (health <= 0)
        {
            isDead = true;
            GameManager.Instance.LoseGame();
            gameObject.SetActive(false);
        }
    }

    private void UpdateHealthUI()
    {
        if (healthText != null)
            healthText.text = "Health: " + health;
    }
}