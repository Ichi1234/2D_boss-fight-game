using UnityEngine;

public abstract class EntityState
{
    public StateMachine stateMachine { get; private set; }

    protected EntityState(StateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public virtual void Enter()
    {

    }

    public virtual void Update()
    {
        
    }

    public virtual void Exit()
    {

    }
}
