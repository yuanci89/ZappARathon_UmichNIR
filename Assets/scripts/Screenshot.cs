using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zappar.Additional.SNS;
using static Zappar.Additional.SNS.ZSaveNShare;

public class Screenshot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cases;
    public GameObject cameraFlipButton;

    void Start()
    {
        ZSaveNShare.Initialize();

    }
 
    public void OnPressed()
    {
        TakeSnapshot();
        toggleButtons(false);
        Debug.Log("Snapshot Taken");
    }
 
 
    
  private void toggleButtons(bool isActive)
    {
        cases.SetActive(isActive);
        cameraFlipButton.SetActive(isActive);
        GetComponent<Image>().enabled=isActive;
    }
 
    public void TakeSnapshot()
    {
        ZSaveNShare.RegisterSNSCallbacks(OnSaved, OnShared, OnPromptClosed);
        StartCoroutine(ZSaveNShare.TakeSnapshot(OnSnapshotCaptured));
    }

    public void OnSnapshotCaptured()
    {
        Debug.Log("Open prompt");
        ZSaveNShare.OpenSNSSnapPrompt();
    }

    public void OnSaved()
    {
        Debug.Log("Prompt saved");
    }

    public void OnShared()
    {
        Debug.Log("Prompt shared");
    }

    public void OnPromptClosed()
    {
        Debug.Log("Save and share prompt closed");
        toggleButtons(true);

        ZSaveNShare.DeregisterSNSCallbacks(OnSaved, OnShared, OnPromptClosed);
    }
}