// MoveTo.cs
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour {

    public Transform goal;
    public Animator anim;

    void Update() {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        if (agent.remainingDistance < 0.1f) {
            anim.SetBool("Running" , false);
        } else {
            anim.SetBool("Running", true);
        }
    }
}