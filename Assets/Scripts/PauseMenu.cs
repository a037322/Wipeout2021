using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Collections;
using UnityEngine.Audio;
//using UnityEngine.Audio;
//using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPause = false;
    //public GameObject canvas;
    public GameObject menu;
    public AudioMixer audioMixer;
    public GameObject optionsMenu;
    //public GameObject count;
    //public GameObject timer;
    //public GameObject hudContainer;
    MouseLook mouseLookController;
    MouseLook mouseLookCamera;

    private void Start()
    {
        mouseLookController = GetComponent<MouseLook>();
        mouseLookCamera = Camera.main.GetComponent<MouseLook>();
        //canvas = CanvasObject.GetComponent<Canvas>();
    }
    //public AudioMixer audioMixer;
    //public GameObject soundMenu;
    //public Canvas overlayCanvas;
    //public float soundSaved;
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if(GameIsPause)
                {
                    Resume(); 
                    //mouseLookController.enabled = true;
                    //mouseLookCamera.enabled = true;
                    
            }
            else
                {
                    Pause();
                    //mouseLookController.enabled = false;
                    //mouseLookCamera.enabled = false;
                    
            }
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        menu.SetActive(true);
        GameIsPause = true;
        //hudContainer.SetActive(false);
        //count.SetActive(false);
        //timer.SetActive(false);
        //canvas.SetActive(false);
        /*audioMixer.GetFloat("Music", out soundSaved);
        if (soundSaved > -30f)
        {
            audioMixer.SetFloat("Music", -30f);
        }*/
        //overlayCanvas.GetComponent<GraphicRaycaster>().enabled = false;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
        GameIsPause = false;
        //hudContainer.SetActive(true);
        //count.SetActive(true);
        //timer.SetActive(true);
        //canvas.SetActive(true);
        //audioMixer.SetFloat("Musicq", soundSaved);
        //overlayCanvas.GetComponent<GraphicRaycaster>().enabled = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
    }

    public void Controls()
    {
        Debug.Log("entering controls ....");
    }

    public void SetSound(Slider slider)
    {
        audioMixer.SetFloat("SoundEffects", slider.value);
    }
    public void SetMaster(Slider slider)
    {
        audioMixer.SetFloat("Master", slider.value);
    }
    public void SetMusic(Slider slider)
    {
        audioMixer.SetFloat("Music", slider.value);
    }

    /* public void SoundMenu()
     {
         menu.SetActive(false);
         soundMenu.SetActive(true);
     }

     public void GoBack()
     {
         menu.SetActive(true);
         soundMenu.SetActive(false);
     }

     public void AjustSound(Slider slider)
     {
         audioMixer.SetFloat("SoundEffects", slider.value);
     }
     public void AjustMaster(Slider slider)
     {
         audioMixer.SetFloat("Master", slider.value);
     }
     public void AdjustMusic(Slider slider)
     {
         audioMixer.SetFloat("Music", slider.value);
     }*/
}
