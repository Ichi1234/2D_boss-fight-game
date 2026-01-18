using UnityEngine;

public class Entity_Vfx : MonoBehaviour
{
    [Header("Attack Details")]
    [SerializeField] private Transform attackVfx;

    private void Awake()
    {
        
    }
    public void CreateAttackVfx()
    {
        attackVfx.gameObject.SetActive(true);
    }
}
