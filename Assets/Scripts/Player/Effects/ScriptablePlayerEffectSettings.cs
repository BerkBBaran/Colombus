using System.Collections;
using UnityEngine;

namespace Colombus.PlayerEffects
{
    [CreateAssetMenu(fileName = "PlayerEffectSetting", menuName = "Player/Effects/New Effect Settings")]
    public class ScriptablePlayerEffectSettings : ScriptableObject
    {
        [SerializeField] private float _flashingEffectTargetAlpha = 0.5f;
        public float FlashingEffectTargetAlpha => _flashingEffectTargetAlpha;

        [SerializeField] private int _flashingEffectCount = 3;
        public float FlashingEffectCount => _flashingEffectCount;
    }
}