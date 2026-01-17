using UnityEngine;

public class Player_MoveState : PlayerState
{
    public Player_MoveState(Player player, StateMachine stateMachine) : base(player, stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("I moving");
    }
}
