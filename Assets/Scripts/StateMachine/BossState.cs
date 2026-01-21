using UnityEngine;

public class BossState : EntityState
{
    public BossState(Boss boss, StateMachine stateMachine, string animParam) : base(stateMachine, animParam)
    {
    }
}
