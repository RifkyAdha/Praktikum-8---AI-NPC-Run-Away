using UnityEngine;
using UnityEngine.AI;

public class Chaser : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target = null;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
            MoveToTarget();
    }

    void MoveToTarget()
    {
        agent.SetDestination(target.position);
        agent.isStopped = false;
    }
}
