﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth = 2;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "projectile")
            enemyHealth--;

        if (enemyHealth < 1)
        {
            Destroy(gameObject);
        }
    }
}
