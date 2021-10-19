using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Colombus.Environment
{
    public class EntityBase : MonoEntity
    {
        // TODO: Random scaling and random rotation for obstacle islands

        [SerializeField] private EntityShiftingSettings _settings;


        private void Update()
        {
            transform.position = ShiftObject(transform.position, Vector3.down, _settings.ShiftingSpeed);
        }

        public override Vector3 ShiftObject(Vector3 sourcePos, Vector3 dir, float speed)
        {
            return base.ShiftObject(sourcePos, dir, speed);
        }
    }
}