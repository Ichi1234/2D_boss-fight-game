using System;
using UnityEngine;

public class Player_Berserk : MonoBehaviour
{
    [Header("Berserk Details")]
    [SerializeField] private BerserkerStage[] berserkerStages;
    [Range(0, 1)]
    [SerializeField] private float soundLevels;

    public static event Action OnStageChanged;
    public BerserkerStage curStage { get; private set; }


    private void Update()
    {
        foreach (var stage in berserkerStages)
        {
            if (soundLevels >= stage.threshold)
            {
                ApplyStage(stage);
            }
        }
    }

    private void ApplyStage(BerserkerStage stage)
    {
        curStage = stage;
        OnStageChanged?.Invoke();
    }

}
