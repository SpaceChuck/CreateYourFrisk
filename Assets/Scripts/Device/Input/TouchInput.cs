using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

public class TouchInput : IUndertaleInput
{
    public static FixedJoystick TouchJoystick;
    public static Button Confirm;
    public static Button Cancel;
    public static Button Menu;

    private static ButtonState StateFor(KeyCode c)
    {
        if (Input.GetKeyDown(c)) return ButtonState.PRESSED;
        if (Input.GetKeyUp(c)) return ButtonState.RELEASED;
        return Input.GetKey(c) ? ButtonState.HELD
                               : ButtonState.NONE;
    }
}
