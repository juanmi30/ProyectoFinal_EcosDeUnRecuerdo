using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public TextFade textFade;
    public bool fadeOutOnExit = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && textFade != null)
        {
            textFade.FadeIn();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (fadeOutOnExit && other.CompareTag("Player") && textFade != null)
        {
            textFade.FadeOut();
        }
    }
}
