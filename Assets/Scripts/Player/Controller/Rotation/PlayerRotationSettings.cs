using System.Collections;
using UnityEngine;

namespace Colombus.PlayerControls
{
    [CreateAssetMenu(fileName = "RotationSettings", menuName = "Player/New Rotation Settings")]
    public class PlayerRotationSettings : ScriptableObject
    {
        [SerializeField] private float _rotationSpeed = 1f;
        [SerializeField] private float _straightenSpeed = 1f;
        [SerializeField] private float _instantBreakSpeed = 1f;
        public float RotationSpeed => _rotationSpeed;
        public float StraightenSpeed => _straightenSpeed;
        public float InstantBreakSpeed=> _instantBreakSpeed;
    }
}