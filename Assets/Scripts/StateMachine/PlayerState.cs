using UnityEngine;

public abstract class PlayerState : EntityState
{
    protected Player player;

    public PlayerState(Player player, StateMachine stateMachine) : base(stateMachine)
    {
        this.player = player;
    }
}
