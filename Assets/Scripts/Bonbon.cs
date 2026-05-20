using UnityEngine;

public class Bonbon : MonoBehaviour
{
    public AudioClip sonDegat;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bonbon"))
        {
            if (sonDegat != null)
                AudioSource.PlayClipAtPoint(sonDegat, transform.position);

            NombreDeVie.Instance.LoseLife();
            Destroy(other.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bonbon"))
        {
            if (sonDegat != null)
                AudioSource.PlayClipAtPoint(sonDegat, transform.position);

            NombreDeVie.Instance.LoseLife();
            Destroy(other.gameObject);
        }
    }
}