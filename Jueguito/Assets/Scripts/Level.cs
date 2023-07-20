using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int level = 1;
    public float experience = 0;
    public float experienceRequired = 100;

    private void Start()
    {
        CalculateRequiredExperience();
    }

    private void CalculateRequiredExperience()
    {
        experienceRequired *= 1.1f;
    }

    public void GainExperience(float amount)
    {
        experience += amount;
        Debug.Log("Ganaste " + amount + " experiencia.");

        if (experience >= experienceRequired)
        {
            experience = 0f;
            LevelUp();
        }
    }

    private void LevelUp()
    {
        level++;
        Debug.Log("¡Subiste de nivel! Ahora eres nivel " + level + ".");
        CalculateRequiredExperience();
    }
}
