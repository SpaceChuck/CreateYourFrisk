using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowJoystick : MonoBehaviour
{

    public SimpleInput.KeyInput keyUp = new SimpleInput.KeyInput();
    public SimpleInput.KeyInput keyDown = new SimpleInput.KeyInput();
    public SimpleInput.KeyInput keyLeft = new SimpleInput.KeyInput();
    public SimpleInput.KeyInput keyRight = new SimpleInput.KeyInput();

    FixedJoystick joystick;

    void Awake()
    {
        joystick = this.GetComponent<FixedJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        if (joystick.Horizontal < -0.25) { keyLeft.value = true; } else { keyLeft.value = false; }
        if (joystick.Horizontal > 0.25) { keyRight.value = true; } else { keyRight.value = false; }
        if (joystick.Vertical < -0.25) { keyDown.value = true; } else { keyDown.value = false; }
        if (joystick.Vertical > 0.25) { keyUp.value = true; } else { keyUp.value = false; }
    }

    private void OnEnable()
    {
        keyUp.StartTracking();
        keyDown.StartTracking();
        keyLeft.StartTracking();
        keyRight.StartTracking();
    }
    
    private void OnDisable()
    {
        keyUp.StopTracking();
        keyDown.StopTracking();
        keyLeft.StopTracking();
        keyRight.StopTracking();
	}
}
