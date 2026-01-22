using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Entity_Health : MonoBehaviour
{
    [SerializeField] public float maxHealth = 100;
    [SerializeField] private UI_HealthBar uiHealthbar;
    [SerializeField] private float attackKnockback = 0.1f;

    public float curHealth;

    private void Awake()
    {
        curHealth = maxHealth;
    }

    private void Start()
    {
        uiHealthbar.SetupMaxSliderHealthValue(maxHealth);
        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        uiHealthbar.UpdateHealth(curHealth);
    }

    public float GetPercentHealth() => curHealth / maxHealth * 100;

    public void TakeDamage(float damage, float attackDir, Transform target)
    {
        ReduceHealth(damage);
        KnockBack(attackDir, target);
    }

    public void KnockBack(float attackDir, Transform target)
    {
        target.GetComponent<Entity>().SetVelocity(attackDir * attackKnockback, attackKnockback / 2);
    }

    public void ReduceHealth(float damage)
    {
        curHealth -= damage;
        UpdateHealthUI();
    }
}
