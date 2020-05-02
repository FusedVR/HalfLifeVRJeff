using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Tracking.Collision;

public class Breakable : MonoBehaviour
{
    public Transform goal;

    private bool setGoal = false;

    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.layer == LayerMask.NameToLayer("UI")) {
            setGoal = false;
            Debug.LogError("HAND GRAB");
        } else if (setGoal) {
            goal.position = transform.position;
        }
    }

    public void OnCollisionExit(Collision collision) {
        if (collision.gameObject.layer == LayerMask.NameToLayer("UI")) {
            setGoal = true;
            Debug.LogError("HAND DROP");
        }
    }
}
