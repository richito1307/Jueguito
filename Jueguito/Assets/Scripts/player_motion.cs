using UnityEngine;

public class player_motion : MonoBehaviour
{
    [SerializeField] private float motionSpeed;
    [SerializeField] private Vector2 direction;
    [SerializeField] FloatingJoystick joystick;
    private Rigidbody2D rb2D;
 
    private void Start() {
        rb2D = GetComponent<Rigidbody2D>(); 
    }

    private void Update() {
        direction = (Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal);

    }

    private void FixedUpdate() {
        rb2D.MovePosition(rb2D.position + direction * motionSpeed * Time.fixedDeltaTime);
    }
}
