using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public string sceneToLoad = "EscenaFinal";   // pon aquí el nombre de tu escena final

    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;
        if (!other.CompareTag("Player")) return;

        triggered = true;
        SceneManager.LoadScene(sceneToLoad);
        // si quisieras solo congelar y mostrar texto:
        //Time.timeScale = 0f;
        //endPanel.SetActive(true);
    }
}
