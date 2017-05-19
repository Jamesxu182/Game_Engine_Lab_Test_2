using UnityEngine;
using System.Collections;
using System;

public class ArriveBehaviour : SteeringBehaviour {

    public Vector3 target;

    public Boolean isArrived = false;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	    if(Vector3.Distance(target, transform.position) < 1.0f)
        {
            if(target == Vector3.zero)
            {
                Destroy(this);
            }
            isArrived = true;
        }

        else
        {
            isArrived = false;
        }
	}

    public override Vector3 Calculate()
    {
        return boid.ArriveForce(this.target, 0.5f);
    }
}
