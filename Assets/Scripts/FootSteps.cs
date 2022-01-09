using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    [SerializeReference] AudioSource footsteps;
    [SerializeReference] CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 0f && footsteps.isPlaying == false)
        {
            footsteps.volume = Random.Range(0.8f, 1);
            footsteps.pitch = Random.Range(0.8f, 1.1f);
            footsteps.Play();
        }
    }
}
