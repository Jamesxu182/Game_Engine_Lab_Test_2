using UnityEngine;
using System.Collections;

public class BeeStateMachine : StateMachine {
    private ArriveBehaviour arriveBehaviour;

    // Use this for initialization
    void Start () {
        state = new ArriveState();
        arriveBehaviour = GetComponent<ArriveBehaviour>();
    }

    // Update is called once per frame
    void Update () {
        if(arriveBehaviour.isArrived)
        {
            ChangeState(new BackState());
        }
	}
}
