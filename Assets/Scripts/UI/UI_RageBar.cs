using UnityEngine;
using UnityEngine.UI;

public class UI_RageBar : MonoBehaviour
{
    private Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public void UpdateRageBar(float rageValue)
    {
        slider.value = rageValue;

    }
}


