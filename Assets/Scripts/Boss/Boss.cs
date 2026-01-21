using UnityEngine;
using UnityEngine.Windows;

public class Boss : Entity
{
    public Boss_IdleState idleState { get; private set; }


    protected override void Awake()
    {
        base.Awake();

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        anim.SetBool("isIdle", true);

        idleState = new Boss_IdleState(this, stateMachine, "isIdle");
       

        stateMachine.Initialize(idleState);

    }
}
