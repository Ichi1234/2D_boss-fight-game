using UnityEngine;
using UnityEngine.PlayerLoop;

public abstract class EntityState
{
    public StateMachine stateMachine { get; private set; }
    protected float stateTimer;

    protected Entity_Vfx entityVfx;
    public string animParam { get; private set; }
    protected bool triggerCalled = false;


    protected EntityState(StateMachine stateMachine, string animParam)
    {
        this.stateMachine = stateMachine;
        this.animParam = animParam;
    }


    public virtual void Enter()
    {
        triggerCalled = false;
    }

    public virtual void Update()
    {
        stateTimer -= Time.deltaTime;
    }


    public virtual void Exit()
    {

    }

    public void AnimationTriggered()
    {
        triggerCalled = true;
    }

    public virtual void UpdateAnimationParameter(bool activate)
    {

    }


}
