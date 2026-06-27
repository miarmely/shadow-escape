using UnityEngine;

public class GhostAI : MonoBehaviour
{
    [SerializeField] public Transform player;
    public float patrolSpeed = 2f;
    public float chaseSpeed = 3.5f;
    [SerializeField] public Transform pointA;
    [SerializeField] public Transform pointB;

    private Transform targetPoint;
    private bool canSeePlayer = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        targetPoint = pointA;
    }

    void FixedUpdate()
    {
        if (canSeePlayer)
        {
            ChasePlayer();
        }
        else
        {
            Patrol();
        }
    }

    void Patrol()
    {
        Vector2 direction = ((Vector2)targetPoint.position - rb.position).normalized;
        rb.linearVelocity = direction * patrolSpeed;

        if (Vector2.Distance(transform.position, targetPoint.position) < 0.2f)
        {
            targetPoint = targetPoint == pointA ? pointB : pointA;
        }
    }

    void ChasePlayer()
    {
        Vector2 direction = ((Vector2)player.position - rb.position).normalized;
        rb.linearVelocity = direction * chaseSpeed;
    }

    public void SetCanSeePlayer(bool value)
    {
        canSeePlayer = value;
    }
}