using UnityEngine;

public class MusiqueManager : MonoBehaviour
{
    void Start()
    {
        // La musique ne s'arrête pas quand on change de scène
        DontDestroyOnLoad(gameObject);
    }
}