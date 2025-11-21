using UnityEngine;

public class GuardPatrol : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 2f;
    public float waitTime = 1f;
    public Animator animator;

    private int currentIndex = 0;
    private float waitCounter = 0f;

    private void Start()
    {
        if (waypoints.Length > 0)
        {
            transform.position = waypoints[0].position;
        }
    }

    private void Update()
    {
        if (waypoints.Length < 2) return;

        Transform target = waypoints[currentIndex];
        Vector3 dir = target.position - transform.position;
        dir.y = 0; // que no mire hacia arriba/abajo

        // ¿Llegó al punto?
        if (dir.magnitude < 0.1f)
        {
            // Espera un momento antes de ir al siguiente
            waitCounter += Time.deltaTime;
            if (waitCounter >= waitTime)
            {
                currentIndex = (currentIndex + 1) % waypoints.Length;
                waitCounter = 0f;
            }

            if (animator != null)
                animator.speed = 0f;   // pausa animación si quieres
        }
        else
        {
            // Mover
            Vector3 move = dir.normalized * speed * Time.deltaTime;
            transform.position += move;

            // Girar hacia donde va
            if (dir != Vector3.zero)
                transform.forward = dir.normalized;

            if (animator != null)
                animator.speed = 1f;   // animación de caminar en loop
        }
    }
}
