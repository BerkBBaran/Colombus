using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Colombus.Environment
{
    [CreateAssetMenu(fileName = "EntitySetting", menuName = "Entity/New Entity Setting")]
    public class EntitySettings : ScriptableObject
    {
        [SerializeField] private float _shiftingSpeed;
        public float ShiftingSpeed => _shiftingSpeed;
    }
}