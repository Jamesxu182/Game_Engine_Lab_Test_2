using UnityEngine;
using System.Collections;

public class BackState : State {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void Enter()
    {
        fsm.GetComponent<ArriveBehaviour>().enabled = true;
        fsm.GetComponent<ArriveBehaviour>().target = new Vector3(0, 0, 0);
    }

    public override void Exit()
    {
        fsm.GetComponent<ArriveBehaviour>().enabled = false;
    }
}
