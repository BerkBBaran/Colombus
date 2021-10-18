using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Colombus.PlayerControls
{
    [CreateAssetMenu(fileName = "MovementSettings", menuName = "Player/New Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        [SerializeField] private float _speed = 1f;
        public float Speed => _speed;
    }
}