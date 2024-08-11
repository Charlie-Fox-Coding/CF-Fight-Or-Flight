using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseCredits : MonoBehaviour
{
    public GameObject creditsCanvas;
    public GameObject mainMenuCanvas;

    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        creditsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }

    public void OpenCredits()
    {
        sound.Play();
        creditsCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

    public void CloseCredits()
    {
        sound.Play();
        creditsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }
}
