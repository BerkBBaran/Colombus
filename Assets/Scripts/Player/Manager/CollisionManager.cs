using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionManager : MonoBehaviour
{
    public event Action OnTakeDamage;

     
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<IDamagable>() != null)
        {
            collision.gameObject.GetComponent<IDamagable>().Damage();

            PlayerGhostModeController.Instance.StartCoroutine("GhostModeRoutine");
            OnTakeDamage?.Invoke();
        }
    }
}
