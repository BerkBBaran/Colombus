using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadingEffect : MonoBehaviour
{
    public static void FadeColorEffect(GameObject go, Color targetColor, float duration)
    {
        Image image = go.GetComponent<Image>();
        image.CrossFadeColor(targetColor, duration, false, false);
    }

    public static void FlashingEffect(GameObject go, float targetAlpha, float duration)
    {
        Image image = go.GetComponent<Image>();
        float initialAlpha = image.color.a;
        image.CrossFadeAlpha(targetAlpha, duration, false);
        // back to initialAlpha
    }

}
