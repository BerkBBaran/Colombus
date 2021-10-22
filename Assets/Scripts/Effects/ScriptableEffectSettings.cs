using System.Collections;
using UnityEngine;

namespace Colombus.Effects
{
    [CreateAssetMenu(fileName = "EffectSetting", menuName = "Effects/New Effect Settings")]
    public class ScriptableEffectSettings : ScriptableObject
    {
        [SerializeField] private float _fadeAwayEffectTime;
        public float FadeAwayEffectTime => _fadeAwayEffectTime;
    }
}