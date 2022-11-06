using UnityEngine;
using UnityEngine.AI;

public class RunAway : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform chaser;

    public float Dist = 5;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (chaser == null)
            return;

        Vector3 nDir = (chaser.position - transform.position).normalized;

        nDir = Quaternion.AngleAxis(45, Vector3.up) * nDir;

        MoveToPos(transform.position - (nDir * Dist));
    }

    void MoveToPos(Vector3 pos)
    {
        agent.SetDestination(pos);
        agent.isStopped = false;
    }

    /*
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Vector3 direction = (chaser.position - transform.position).normalized;

        float mag = direction.magnitude;

        Gizmos.DrawLine(transform.position, transform.position + direction);
    } */
}
