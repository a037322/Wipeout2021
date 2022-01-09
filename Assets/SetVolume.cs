using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer audioMixer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
