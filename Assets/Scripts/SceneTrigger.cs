using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public string sceneToLoad = "NombreDeTuEscena";   // cámbialo en el Inspector

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("SceneTrigger: OnTriggerEnter con " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("SceneTrigger: Player detectado, cargando escena: " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.Log("SceneTrigger: El objeto que entró NO tiene tag Player.");
        }
    }
}
