using UnityEngine;

public class Entity : MonoBehaviour
{
    public StateMachine stateMachine { get; private set; }

    protected virtual void Awake()
    {
        stateMachine = new StateMachine();
    }

    protected virtual void Start()
    {
        
    }

    protected virtual void Update()
    {
        stateMachine.CallUpdateCurrentState();
    }
}
