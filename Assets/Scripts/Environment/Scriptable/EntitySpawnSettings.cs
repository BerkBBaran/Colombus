using System.Collections;
using UnityEngine;

namespace Colombus.Environment
{
    [CreateAssetMenu(fileName = "SpawnSetting", menuName = "Entity/New Spawn Setting")]
    public class EntitySpawnSettings : ScriptableObject
    {
        [SerializeField] private float _maxScalingRate = 1.5f;
        public float MaxScalingRate => _maxScalingRate;

        [SerializeField] private float _timeBetweenSpawns = 1f;
        public float TimeBetweenSpawns => _timeBetweenSpawns;

        [SerializeField] private bool _isScalingActive = true;
        public bool IsScalingActive => _isScalingActive;

        [SerializeField] private bool _isRotatingActive = true;
        public bool IsRotatingActive => _isRotatingActive;
    }
}