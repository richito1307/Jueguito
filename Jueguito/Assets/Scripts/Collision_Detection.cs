using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision_Detection : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (CompareTag("Player"))
            {
                Player_health healthP = GetComponent<Player_health>();
                if (healthP != null)
                {
                    healthP.UpdateHealth(-.01f);
                    Debug.Log(healthP.vidaActual);
                }
            }
        }
    }
}
