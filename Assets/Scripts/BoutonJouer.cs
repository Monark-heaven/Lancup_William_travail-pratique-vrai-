using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void JouerNiveau1()
    {
        SceneManager.LoadScene("Niveau1");
    }
}