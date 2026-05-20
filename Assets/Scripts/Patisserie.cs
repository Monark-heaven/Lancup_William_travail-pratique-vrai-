using UnityEngine;

public class Patisserie : MonoBehaviour
{
    // C'est grâce au "non-trigger" que la patisserie bloque le joueur.

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("La patisserie bloque le joueur.");
        }
    }
}