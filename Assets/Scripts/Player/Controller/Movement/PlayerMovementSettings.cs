using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Colombus.PlayerControls
{
    [CreateAssetMenu(fileName = "MovementSettings", menuName = "Player/New Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        [SerializeField] private float _movementSpeed = 0.15f;
        [SerializeField] private float _boostSpeed = 0.06f;
        [SerializeField] private float _dragDownSpeed = 0.04f;
        public float MovementSpeed => _movementSpeed;
        public float BoostSpeed => _boostSpeed;

        public float DragDownSpeed => _dragDownSpeed;
    }
}