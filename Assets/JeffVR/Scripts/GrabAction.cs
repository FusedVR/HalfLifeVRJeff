using Zinnia.Action;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class GrabAction : BooleanAction {

    public string SteamVRAction; //i.e. Fire
    public Hand hand;

    private SteamVR_Action_Boolean button;

    private void Start() {
        button = SteamVR_Input.GetAction<SteamVR_Action_Boolean>(SteamVRAction);
    }

    protected virtual void Update() {
        Receive(button.GetState(hand.handType));
    }
}
