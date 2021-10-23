using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionManager : MonoBehaviour
{
    public event Action OnTakeDamage;
    private PlayerGhostModeController playerGhostModeController;

    private void Awake()
    {
        playerGhostModeController = GetComponent<PlayerGhostModeController>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<IDamagable>() != null)
        {
            collision.gameObject.GetComponent<IDamagable>().Damage();

            playerGhostModeController.StartCoroutine("GhostModeRoutine");
            OnTakeDamage?.Invoke();
        }
    }
}
