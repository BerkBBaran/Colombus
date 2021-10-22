using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Colombus.PlayerEffects
{
    public class PlayerEffectController : MonoBehaviour
    {
        [SerializeField] private ScriptablePlayerEffectSettings _effectSettings;

        private void OnEnable()
        {
            PlayerGhostModeController.Instance.OnGhostModeStarted += FlashingEffect;
        }

        public void FlashingEffect(GameObject go, float duration)
        {
            StartCoroutine(FlashingEffectRoutine(go, duration));
        }

        private IEnumerator FlashingEffectRoutine(GameObject go, float duration)
        {
            Debug.Log("Coroutine started");
            Image image = go.GetComponent<Image>();
            float initialAlpha = image.color.a;
            float timeBetweenFlashes = (float)(duration / (2 * _effectSettings.FlashingEffectCount));
            WaitForSeconds seconds = new WaitForSeconds(timeBetweenFlashes);

            for (int i = 0; i < _effectSettings.FlashingEffectCount; i++)
            {
                image.CrossFadeAlpha(_effectSettings.FlashingEffectTargetAlpha, timeBetweenFlashes, false);
                yield return seconds;
                image.CrossFadeAlpha(initialAlpha, timeBetweenFlashes, false);
                yield return seconds;
            }
        }

        private void OnDisable()
        {
            PlayerGhostModeController.Instance.OnGhostModeStarted -= FlashingEffect;
        }
    }
}