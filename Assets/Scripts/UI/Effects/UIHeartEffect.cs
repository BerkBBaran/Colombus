using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Colombus.UIEffects
{
    public class UIHeartEffect : MonoBehaviour
    {
        [SerializeField] private UIHeartEffectSettings _effectSettings;

        private UIHealth _uiHealth;

        private void Awake()
        {
            _uiHealth = FindObjectOfType<UIHealth>();    
        }

        private void OnEnable()
        {
            _uiHealth.OnHeartRemoved += FadeAwayEffect;
        }

        public void FadeAwayEffect(RectTransform obj)
        {
            LeanTween.color(obj, _effectSettings.TargetColor, _effectSettings.HeartFadingTime);
        }

        private void OnDisable()
        {
            _uiHealth.OnHeartRemoved -= FadeAwayEffect;
        }
    }
}