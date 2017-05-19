using UnityEngine;
using System.Collections;

public class State
{
    public StateMachine fsm;

    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void Think() { }

}
