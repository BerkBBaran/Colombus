using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Colombus.PlayerEffects
{
    public class PlayerEffectController : MonoBehaviour
    {
        [SerializeField] private ScriptablePlayerEffectSettings _effectSettings;

        PlayerGhostModeController playerGhostModeController;

        private void Awake()
        {
            playerGhostModeController = GetComponent<PlayerGhostModeController>();
        }

        private void OnEnable()
        {
            playerGhostModeController.OnGhostModeStarted += FlashingEffect;
        }

        public void FlashingEffect(GameObject go, float duration)
        {
            if (go == null)
            {
                Debug.Log("null");
            }
            StartCoroutine(FlashingEffectRoutine(go, duration));
        }

        private IEnumerator FlashingEffectRoutine(GameObject go, float duration)
        {
            float timeBetweenFlashes = (float)(duration / (2 * _effectSettings.FlashingEffectCount));
            WaitForSeconds seconds = new WaitForSeconds(timeBetweenFlashes);

            for (int i = 0; i < _effectSettings.FlashingEffectCount; i++)
            {
                LeanTween.alpha(go, _effectSettings.FlashingEffectTargetAlpha, timeBetweenFlashes);
                yield return seconds;
                LeanTween.alpha(go, 1, timeBetweenFlashes);
                yield return seconds;
            }
        }

        private void OnDisable()
        {
            playerGhostModeController.OnGhostModeStarted -= FlashingEffect;
        }
    }
}