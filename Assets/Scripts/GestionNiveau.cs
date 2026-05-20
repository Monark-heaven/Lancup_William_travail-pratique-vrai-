using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class GestionNiveau : MonoBehaviour
{
    public bool viandeRamassee = false;
    public bool viandePresente = false;

    private int totalCercles;
    public int cerclesRamasses = 0;

    public TextMeshProUGUI texteBienJoue;
    public float delaiAvantRetour = 2f;

    public AudioClip voixExplication;

    void Start()
    {
        cerclesRamasses = 0;
        viandeRamassee = false;
        totalCercles = GameObject.FindGameObjectsWithTag("Collectible").Length;
        viandePresente = FindObjectOfType<Viande>() != null;
        Debug.Log("Total collectibles trouvés : " + totalCercles);

        if (voixExplication != null)
            GetComponent<AudioSource>().PlayOneShot(voixExplication);
    }

    public void CercleRamasse()
    {
        cerclesRamasses++;
        Debug.Log("CercleRamasse appelé ! Total : " + cerclesRamasses + "/" + totalCercles);

        if (cerclesRamasses >= totalCercles)
        {
            if (!viandePresente || viandeRamassee)
            {
                TerminerNiveau();
            }
        }
    }

    public bool TousLesLegumesRamasses()
    {
        return cerclesRamasses >= totalCercles;
    }

    public void TerminerNiveau()
    {
        StartCoroutine(FinNiveau());
    }

    IEnumerator FinNiveau()
    {
        texteBienJoue.gameObject.SetActive(true);
        yield return new WaitForSeconds(delaiAvantRetour);

        // Charge automatiquement le niveau suivant
        int sceneSuivante = SceneManager.GetActiveScene().buildIndex + 1;
        if (sceneSuivante >= SceneManager.sceneCountInBuildSettings)
        {
            // Retourne à l'écran titre
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(sceneSuivante);
        }
    }
}