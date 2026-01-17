using UnityEngine;

public class Player_IdleState : PlayerState
{
    public Player_IdleState(Player player, StateMachine stateMachine) : base(player, stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("YAY I'm here");
    }

    public override void Update()
    {
        base.Update();

        if (player.moveInput.x != 0)
        {
            stateMachine.ChangeState(player.playerMoveState);
        }
    }
}
