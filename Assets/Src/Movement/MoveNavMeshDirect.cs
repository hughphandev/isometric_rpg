using UnityEngine;
using UnityEngine.AI;

public class MoveNavMeshDirect : MonoBehaviour, MovableDirect
{
    private NavMeshAgent agent;

    private void Awake() {
        agent = GetComponent<NavMeshAgent>();
    }

    public void MoveTo(Vector3 position)
    {
        agent.SetDestination(position);
    }
}