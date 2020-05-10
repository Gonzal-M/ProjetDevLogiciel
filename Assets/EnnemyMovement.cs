﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMovement : MonoBehaviour
{
    private float x;
    private float y;
    private float timer;
    public float vitesse;       //le nombre de secondes entre chaque mouvement de l'ennemi

    void Start()
    {
        x=gameObject.transform.position.x;
        y=gameObject.transform.position.y;
        timer=0.0f;
        vitesse = 1f;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            y--;
            gameObject.transform.position = new Vector3(x, y, 0f);
            timer = vitesse;
        }
    } 
}