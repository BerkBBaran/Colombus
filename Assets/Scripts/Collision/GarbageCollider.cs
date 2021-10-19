using System.Collections;
using UnityEngine;

namespace Colombus.Collision
{
    public class GarbageCollider : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(collision.gameObject);
        }
    }
}