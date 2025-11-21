using UnityEngine;

public class AudioFadeIn : MonoBehaviour
{
    public float duration = 2f;
    private AudioSource audioSource;
    private float targetVolume;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Guardamos el volumen final deseado (del inspector)
        targetVolume = audioSource.volume;

        // Empezamos desde volumen cero para el fade-in
        audioSource.volume = 0f;

        // Iniciamos el fade
        StartCoroutine(FadeIn());
    }

    private System.Collections.IEnumerator FadeIn()
    {
        float t = 0f;

        while (t < duration)
        {
            t += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(0f, targetVolume, t / duration);
            yield return null;
        }

        // Asegurar que termine EXACTAMENTE en el volumen deseado
        audioSource.volume = targetVolume;
    }
}
