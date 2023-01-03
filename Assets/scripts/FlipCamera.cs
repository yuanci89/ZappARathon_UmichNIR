using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Zappar;

public class FlipCamera : MonoBehaviour
{
    public ZapparCamera cam1;
    static bool cams = true;

    public void Start()
    {
        cam1.UseFrontFacingCamera = cams;
        cam1.MirrorCamera = cams;
        Debug.Log(String.Format("Front {0}", cam1.UseFrontFacingCamera));
    }
    public void OnFlip ()
    {
        cams = !cams;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
