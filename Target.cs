using UnityEngine;

public class Target : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "StylusCursor")
        {
            transform.position = new Vector3(
                Random.Range(-1.5f, 1.5f),
                0.05f,
                Random.Range(-1.5f, 1.5f)
            );
        }
    }
}
