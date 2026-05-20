using UnityEngine;

public class Couteau : MonoBehaviour
{
    public static bool CouteauRecupere = false;
    public AudioClip sonCouteau;

    void Start()
    {
        CouteauRecupere = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            CouteauRecupere = true;
            if (sonCouteau != null)
        {
            AudioSource.PlayClipAtPoint(sonCouteau, transform.position);
        }
        {
            Destroy(gameObject);
        }
    }
}