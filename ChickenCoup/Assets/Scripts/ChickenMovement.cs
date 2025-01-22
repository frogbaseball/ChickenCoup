using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ChickenMovement : MonoBehaviour {
    private NavMeshAgent agent;
    private Vector3 destination;
    [HideInInspector] public bool IsRigged = false;
    [HideInInspector] public ChickenPositionSetter ChickenPositionSetter;
    private void Start() {
        agent = GetComponent<NavMeshAgent>();
        destination = ChickenPositionSetter.GetRandomDestination();
        agent.SetDestination(destination);
    }
    private void Update() {
        if (Vector3.Distance(transform.position, destination) < 1f && !IsRigged) {
            destination = ChickenPositionSetter.GetRandomDestination();
            agent.SetDestination(destination);
        }
        if (Vector3.Distance(transform.position, destination) < 1f && IsRigged) {
            destination = ChickenPositionSetter.GetRandomDestinationForWinningColor();
            agent.SetDestination(destination);
        }
    }
}