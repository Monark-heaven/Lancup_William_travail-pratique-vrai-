using UnityEngine;

public class Viande : MonoBehaviour
{
    public AudioClip sonViande;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Couteau.CouteauRecupere)
            {
                if (sonViande != null)
                {
                    AudioSource.PlayClipAtPoint(sonViande, transform.position);
                }

                gameObject.SetActive(false);
                GestionNiveau gestion = FindObjectOfType<GestionNiveau>();
                gestion.viandeRamassee = true;

                if (gestion.TousLesLegumesRamasses())
                {
                    gestion.TerminerNiveau();
                }
            }
        }
    }
}