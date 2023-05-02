using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shooting : MonoBehaviour
{
    [SerializeField] private GameObject proyectil;
    [SerializeField] private Transform puntoDeDisparo;
    [SerializeField] FixedJoystick joystick;
    [SerializeField] public float tiempoActual = 0f;
    [SerializeField] public float tiempoMaximo = 1f;

    private void FixedUpdate()
    {
        if(joystick.Horizontal >= .5f ||  joystick.Vertical >= .5f )
        {
            Disparar();
        }
        else if(joystick.Horizontal <= -.5f || joystick.Vertical <= -.5f)
        {
            Disparar();
        }
    }

    void Disparar()
    {
        tiempoActual += Time.deltaTime;

        if (tiempoActual >= tiempoMaximo)
        {
            tiempoActual = 0f;
            GameObject bullet = Instantiate(proyectil, puntoDeDisparo.position, puntoDeDisparo.rotation);
            Destroy(bullet, 1f);
        }
    }
}
