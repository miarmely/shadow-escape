using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
            return;

        GameManager.Instance.CollectKey();

        Destroy(gameObject);
    }
}