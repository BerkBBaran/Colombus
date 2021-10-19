using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Colombus.Environment
{
    [CreateAssetMenu(fileName = "ShiftingSetting", menuName = "Entity/New Shifting Setting")]
    public class EntityShiftingSettings : ScriptableObject
    {
        [SerializeField] private float _shiftingSpeed;
        public float ShiftingSpeed => _shiftingSpeed;
    }
}