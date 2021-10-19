using System.Collections;
using UnityEngine;

namespace Colombus.Environment
{
    public class MonoEntity : MonoBehaviour
    {
        [Range(0,100f)]
        [SerializeField] protected double _rarityRate;
        public double RarityRate { get => _rarityRate; }

        [SerializeField] protected EntityType _entityType;
        public EntityType GetEntityType { get => _entityType; }


        public virtual Vector3 ShiftObject(Vector3 sourcePos, Vector3 dir, float speed)
        {
            sourcePos += dir * speed * Time.deltaTime;
            return sourcePos;
        }
    }
}