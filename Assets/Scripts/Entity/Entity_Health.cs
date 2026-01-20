using UnityEngine;

public class Entity_Health : MonoBehaviour
{
    [SerializeField] public float maxHealth = 100;
    [SerializeField] private UI_HealthBar uiHealthbar;

    public float curHealth;

    private void Awake()
    {
        curHealth = maxHealth;
    }

    private void Start()
    {
        uiHealthbar.SetupMaxSliderHealthValue(maxHealth);
    }

    private void UpdateHealthUI()
    {
        uiHealthbar.UpdateHealth(GetPercentHealth());
    }

    public float GetPercentHealth() => curHealth / maxHealth * 100;

    public void ReduceHealth(float damage)
    {
        curHealth -= damage;
        UpdateHealthUI();
    }
}
