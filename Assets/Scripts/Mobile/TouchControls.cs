using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchControls : MonoBehaviour
{
    public GameObject NormalControls;
    public GameObject KeybindSettingsControls;
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "KeybindSettings")
        {
            NormalControls.SetActive(false);
            KeybindSettingsControls.SetActive(true);
        }
        else
        {
            NormalControls.SetActive(true);
            KeybindSettingsControls.SetActive(false);
        }
    }
}
