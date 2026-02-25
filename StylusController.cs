using UnityEngine;

public class StylusCursorController : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); //Moves Left and Right (A and D)
        float z = Input.GetAxis("Vertical");   // Moves up and down (W and S)

        Vector3 move = new Vector3(x, 0, z);
        transform.Translate(move * speed * Time.deltaTime);
    }
}
