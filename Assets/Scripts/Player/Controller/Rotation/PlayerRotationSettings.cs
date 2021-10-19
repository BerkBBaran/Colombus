using System.Collections;
using UnityEngine;

namespace Colombus.PlayerControls
{
    [CreateAssetMenu(fileName = "RotationSettings", menuName = "Player/New Rotation Settings")]
    public class PlayerRotationSettings : ScriptableObject
    {
        [SerializeField] private float _rotationSpeed = 7f;
        [SerializeField] private float _degreeLimit = 45f;

        public float RotationSpeed => _rotationSpeed;
        public float DegreeLimit => _degreeLimit;
    }
}