using UnityEngine;

public class StylusCursorController : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float z = Input.GetAxis("Vertical");   // W/S or Up/Down

        Vector3 move = new Vector3(x, 0, z);
        transform.Translate(move * speed * Time.deltaTime);
    }
}
