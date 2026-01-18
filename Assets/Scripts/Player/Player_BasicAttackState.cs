using UnityEngine;

public class Player_BasicAttackState : Player_AttackState
{

    public Player_BasicAttackState(Player player, StateMachine stateMachine, string animParam) : base(player, stateMachine, animParam)
    {
    }

    public override void Enter()
    {
        HandleAttackPosition(PlayerAttackTypes.Basic);
        HandleAttackRotation(PlayerAttackTypes.Basic);

        base.Enter();

    }

    public override void Update()
    {
        base.Update();

        
    }


}
