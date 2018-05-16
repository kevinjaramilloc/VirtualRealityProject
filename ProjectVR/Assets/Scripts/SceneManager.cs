using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    [Header("User Interface")]
    public GameObject panel;
    //[Header("Game Manager")]
    //public GameObject sceneLogic;

    private void Update()
    {
        StartGameplay();
    }

    public void StartGameplay()
    {
        panel.SetActive(false);
        //sceneLogic.SetActive(true);
    }
}
