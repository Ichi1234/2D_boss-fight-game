using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    public Player_IdleState playerIdleState { get; private set; }
    public Player_MoveState playerMoveState { get; private set; }
    
    public Vector2 moveInput;
    private PlayerInputSet input;


    protected override void Awake()
    {
        base.Awake();

        playerIdleState = new Player_IdleState(this, stateMachine);
        playerMoveState = new Player_MoveState(this, stateMachine);

        input = new PlayerInputSet();

        stateMachine.Initialize(playerIdleState);
    }

    protected override void Update()
    {
        base.Update();
    }


    private void OnEnable()
    {
        input.Enable();

        input.Player.Move.performed += context => moveInput = context.ReadValue<Vector2>();
        input.Player.Move.canceled += context => moveInput = Vector2.zero;
    }

    private void OnDisable()
    {
        input.Disable();
    }
}
