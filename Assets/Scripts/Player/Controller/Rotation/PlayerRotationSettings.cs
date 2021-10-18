using System.Collections;
using UnityEngine;

namespace Colombus.PlayerControls
{
    [CreateAssetMenu(fileName = "RotationSettings", menuName = "Player/New Rotation Settings")]
    public class PlayerRotationSettings : ScriptableObject
    {
        [SerializeField] private float _speed = 1f;
        public float Speed => _speed;
    }
}