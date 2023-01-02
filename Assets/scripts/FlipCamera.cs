using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Zappar;

public class FlipCamera : MonoBehaviour
{
    // IntPtr pipeline = Z.PipelineCreate();
    // public bool useFrontFacingCamera = true;
    // string device = Z.CameraDefaultDeviceId(useFrontFacingCamera);
    // IntPtr camera = Z.CameraSourceCreate(pipeline, device);
    // string device = Z.CameraDefaultDeviceId(useFrontFacingCamera);

    public ZapparCamera cam;
    static int counter = 0;
    // public ZapparCamera camf;
    // public GameObject cameraObject;
    // public GameObject cameraObjectF;
    // public TMP_Text buttonText;

    public void Start()
    {
        // buttonText.text = String.Format("Camera {0}", counter);
        Debug.Log(String.Format("counter {0}", counter));
    }
    public void onClick ()
    {
        counter++;

        if (cam.UseFrontFacingCamera)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        //cam.UseFrontFacingCamera = !cam.UseFrontFacingCamera;
        //cameraObject.SetActive(false);
        //cameraObject.SetActive(true);
        //buttonText.text = String.Format("{0}", cam.UseFrontFacingCamera);

        //if (useFrontFacingCamera == true)
        //{
        //    useFrontFacingCamera = false;
        //    cameraObjectF.SetActive(false);
        //    cameraObject.SetActive(true);
        //    //camf.enabled = false;
        //    //cam.enabled = true;
        //}
        //else if (useFrontFacingCamera == false)
        //{
        //    useFrontFacingCamera = true;
        //    cameraObject.SetActive(false);
        //    cameraObjectF.SetActive(true);
        //    //cam.enabled = false;
        //    //camf.enabled = true;
        //}
        //buttonText.text = String.Format("{0}", useFrontFacingCamera);

        //cam.UseFrontFacingCamera = !cam.UseFrontFacingCamera;
        //Debug.Log(String.Format("button {0}", cam.UseFrontFacingCamera));
        //buttonText.text = String.Format("{0}", cam.UseFrontFacingCamera);
        //cam.Start();

        //if (useFrontFacingCamera == true)
        //{
        //    useFrontFacingCamera = false;
        //}
        //else if (useFrontFacingCamera == false)
        //{
        //    useFrontFacingCamera = true;
        //}

        //Debug.Log(String.Format("button {0}", useFrontFacingCamera));
        //cam.UseFrontFacingCamera = useFrontFacingCamera;

        // cam.UseFrontFacingCamera(useFrontFacingCamera);

    }
}
