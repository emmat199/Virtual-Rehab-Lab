using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>(); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "StylusCursor") 
        {
            // Add score
            FindObjectOfType<ScoreManager>().AddScore();

            // Flash red
            StartCoroutine(FlashRed());
        }
    }

    IEnumerator FlashRed()
    {
        Color original = rend.material.color;
        rend.material.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        rend.material.color = original;
    }
}
