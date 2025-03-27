using System;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static Action OnPlayerHeal;
    private int health;
    public int Health { get => health; }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
