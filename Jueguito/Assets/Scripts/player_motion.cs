using UnityEngine;

public class player_motion : MonoBehaviour
{
    [SerializeField] private float motionSpeed;
    [SerializeField] FixedJoystick joystick;
    [SerializeField] Rigidbody2D rb2D;

    private void FixedUpdate() {
        rb2D.velocity = new Vector2(joystick.Horizontal * motionSpeed, joystick.Vertical * motionSpeed);


        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical);
        rb2D.velocity = movimiento * motionSpeed;
    }
}
