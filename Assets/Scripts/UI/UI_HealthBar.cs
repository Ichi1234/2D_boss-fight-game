using UnityEngine;
using UnityEngine.UI;

public class UI_HealthBar : MonoBehaviour
{
    private Slider slider;
    // 9825
    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public void UpdateHealth(float healthValue)
    {
        slider.value = healthValue;
        
    }

    public void SetupMaxSliderHealthValue(float maxHealth)
    {
        slider.maxValue = maxHealth;
    }
}
