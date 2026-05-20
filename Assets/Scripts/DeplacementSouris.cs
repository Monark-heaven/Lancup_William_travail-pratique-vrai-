using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DeplacementSouris : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 target;

    public AudioClip sonCollecte;
    private AudioSource audioSource;

    void Start()
    {
        target = transform.position;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 mousePos = Mouse.current.position.ReadValue();
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            worldPos.z = 0f;
            target = worldPos;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}