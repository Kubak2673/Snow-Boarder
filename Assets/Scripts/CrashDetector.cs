using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayAmmount = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool playedSFX = false;
    void OnTriggerEnter2D(Collider2D other) 
    {
    if(other.tag == "Object" && !playedSFX)
    {
        playedSFX = true;
        FindObjectOfType<PlayerController>().DisableControls();
        crashEffect.Play();
        GetComponent<AudioSource>().PlayOneShot(crashSFX);
        Invoke("ReloadScene", delayAmmount);
    }
    }
    void ReloadScene( )
    {
        SceneManager.LoadScene(0);
    }
}
