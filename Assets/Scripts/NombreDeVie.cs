using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NombreDeVie : MonoBehaviour
{
    public static NombreDeVie Instance;

    public int vies = 3;
    public TextMeshProUGUI livesText;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        livesText.text = "Vies : " + vies;
    }

    public void LoseLife()
    {
        vies--;
        livesText.text = "Vies : " + vies;

        if (vies <= 0)
        {
            // Recommence le niveau
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}