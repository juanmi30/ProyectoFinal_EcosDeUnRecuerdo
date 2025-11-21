using UnityEngine;
using TMPro;
using System.Collections;     // Necesario para IEnumerator

public class TextFade : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float fadeInTime = 1.5f;
    public float fadeOutTime = 1.5f;

    void Start()
    {
        if (text == null)
            text = GetComponent<TextMeshProUGUI>();

        text.alpha = 0f;
    }

    public void FadeIn()
    {
        StartCoroutine(FadeTextTo(1f, fadeInTime));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeTextTo(0f, fadeOutTime));
    }

    private IEnumerator FadeTextTo(float target, float duration)
    {
        float start = text.alpha;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            text.alpha = Mathf.Lerp(start, target, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        text.alpha = target;
    }
}
