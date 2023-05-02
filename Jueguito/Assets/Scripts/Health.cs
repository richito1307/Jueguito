using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float vidaMaxima = 10f;
    [SerializeField] public float vidaActual;

    private void Start()
    {
        vidaActual = vidaMaxima;
    }

    public void UpdateHealth(float cantidad)
    {
        vidaActual += cantidad;

        if (vidaActual <= 0)
        {
            vidaActual = 0;
            Destroy(gameObject);
        }
        else if (vidaActual > vidaMaxima)
        {
            vidaActual = vidaMaxima;
        }
    }

    public void UpdateMaxHealth(float cantidad)
    {
        vidaMaxima += cantidad;
        vidaActual += cantidad;

        if (vidaMaxima < 1)
        {
            vidaMaxima = 1;
        }
    }
}

