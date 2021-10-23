using System.Collections;
using UnityEngine;

namespace Colombus.UIEffects
{
    [CreateAssetMenu(fileName = "HeartEffectSetting", menuName = "UI/Effects/New Heart Effect Settings")]
    public class UIHeartEffectSettings : ScriptableObject
    {
        [SerializeField] private float _heartFadingTime = 1f;
        public float HeartFadingTime => _heartFadingTime;

        [SerializeField] private Color _targetColor = new Color(100, 100, 100, 0);
        public Color TargetColor => _targetColor;
    }
}