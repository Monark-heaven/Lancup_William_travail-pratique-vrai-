using UnityEngine;

public class NourritureAManger : MonoBehaviour
{
    public bool necessieCouteau = false;
    public AudioClip sonCollecte;
    private bool dejaRamasse = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (dejaRamasse) return;
            dejaRamasse = true;

            if (necessieCouteau && !Couteau.CouteauRecupere)
            {
                return;
            }

            // Joue le son
            if (sonCollecte != null)
            {
                AudioSource.PlayClipAtPoint(sonCollecte, transform.position);
            }

            Destroy(gameObject);
            FindObjectOfType<GestionNiveau>().CercleRamasse();
        }
    }
}