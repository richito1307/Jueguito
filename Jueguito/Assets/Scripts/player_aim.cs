using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_aim : MonoBehaviour
{
    [SerializeField] FixedJoystick joystick;

    private void FixedUpdate()
    {
        if (joystick.Direction == Vector2.zero) return;
        float angle = Mathf.Atan2(joystick.Vertical, joystick.Horizontal);
        float angleR = (180 / Mathf.PI) * angle - 90;
        transform.rotation = Quaternion.Euler(0, 0, angleR);
    }
}
