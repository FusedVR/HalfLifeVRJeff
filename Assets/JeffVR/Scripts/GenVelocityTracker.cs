using UnityEngine;
using Zinnia.Tracking.Velocity;

public class GenVelocityTracker : VelocityTracker {
    
    private Vector3 pastPosition; //tracks the past position
    private Vector3 pastRotation; //tracks the past rotation; ideally should be a quaternion

    private Vector3 deltaPosition = Vector3.zero; //tracks the actual velocity
    private Vector3 deltaRotation = Vector3.zero; //tracks the actual angular velocity

    private void Start() {
        pastPosition = transform.position; //save start position
        pastRotation = transform.rotation.eulerAngles; //save start rotation
    }

    private void Update() {
        deltaPosition = (transform.position - pastPosition) / Time.deltaTime; //calculates the velcoty
        deltaRotation = (transform.rotation.eulerAngles - deltaRotation) / Time.deltaTime; //calculates the angular velocity

        pastPosition = transform.position; //save current position
        pastRotation = transform.rotation.eulerAngles; //save current rotation
    }

    //method from VRTK Velocity Tracker that is overriden for us to send angular velocity to VRTK
    protected override Vector3 DoGetAngularVelocity() {
        return Vector3.zero; //TODO
    }

    //method from VRTK Velocity Tracker that is overriden for us to send velocity to VRTK
    protected override Vector3 DoGetVelocity() {
        return deltaPosition; //return velocity
    }
}
