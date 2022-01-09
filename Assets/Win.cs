using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("First Person Player").SendMessage("Finnish");
        SceneManager.LoadScene(0);
    }
}