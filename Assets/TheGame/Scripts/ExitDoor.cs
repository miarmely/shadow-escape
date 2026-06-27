using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
            return;

        if (GameManager.Instance.HasAllKeys())
        {
            GameManager.Instance.WinGame();
        }
        else
        {
            Debug.Log("Collect all keys first!");
        }
    }
}