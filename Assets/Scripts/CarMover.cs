using UnityEngine;

public class CarMover : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        //Debug.Log("CarMover.Update ejecutándose, t = " + Time.time);
        // Mover el carro en la dirección en la que mira (eje Z del coche)
        transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
    }
}