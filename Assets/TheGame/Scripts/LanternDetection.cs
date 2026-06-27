using UnityEngine;

public class LanternDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ghost"))
        {
            collision.GetComponent<GhostAI>().SetCanSeePlayer(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ghost"))
        {
            collision.GetComponent<GhostAI>().SetCanSeePlayer(false);
        }
    }
}