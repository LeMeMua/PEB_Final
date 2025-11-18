using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ChangeSceneAfterDelay());
    }

    IEnumerator ChangeSceneAfterDelay()
    {
        yield return new WaitForSeconds(10f);   // Espera 10 segundos
        SceneManager.LoadScene("MainMenu");     // Cambia a la escena MainMenu
    }
}
