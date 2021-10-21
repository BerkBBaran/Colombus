using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Colombus.Environment
{
    public class EntityBase : MonoEntity,IDamagable
    {
        [SerializeField] private EntitySettings _shiftingSettings;
        [SerializeField] private EntitySpawnSettings _spawnSettings;
        

        private void Awake()
        {
            if (_spawnSettings.IsRotatingActive)
                SetRandomRotation();
            if (_spawnSettings.IsScalingActive)
                SetRandomScale();
        }

        private void SetRandomScale()
        {
            var rand = Random.Range(1, _spawnSettings.MaxScalingRate);
            transform.localScale = new Vector3(transform.localScale.x * rand, transform.localScale.y * rand, transform.localScale.z);
        }

        private void SetRandomRotation()
        {
            var rand = Random.Range(0, 360);
            transform.Rotate(Vector3.forward, rand, Space.Self);
        }


        private void Update()
        {
            transform.position = ShiftObject(transform.position, Vector3.down, _shiftingSettings.ShiftingSpeed);
        }

        public override Vector3 ShiftObject(Vector3 sourcePos, Vector3 dir, float speed)
        {
            return base.ShiftObject(sourcePos, dir, speed);
        }

        public void Damage()
        {
            //edit later
        }
    }
}