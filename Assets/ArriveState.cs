using UnityEngine;
using System.Collections;

public class ArriveState : State {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void Enter()
    {
        fsm.GetComponent<ArriveBehaviour>().enabled = true;
    }

    public override void Exit()
    {
        //fsm.GetComponent<ArriveBehaviour>().enabled = false;
    }
}
