using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int collectedKeys = 0;
    public int totalKeys = 3;

    public TextMeshProUGUI keyText;
    public GameObject winPanel;
    public GameObject losePanel;

    private bool gameEnded = false;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateKeyUI();

        if (winPanel != null)
            winPanel.SetActive(false);

        if (losePanel != null)
            losePanel.SetActive(false);
    }

    public void CollectKey()
    {
        if (gameEnded) return;

        collectedKeys++;
        UpdateKeyUI();
    }

    public bool HasAllKeys()
    {
        return collectedKeys >= totalKeys;
    }

    public void WinGame()
    {
        if (gameEnded) return;

        gameEnded = true;
        winPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoseGame()
    {
        if (gameEnded) return;

        gameEnded = true;
        losePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    private void UpdateKeyUI()
    {
        if (keyText != null)
            keyText.text = "Keys: " + collectedKeys + "/" + totalKeys;
    }
}