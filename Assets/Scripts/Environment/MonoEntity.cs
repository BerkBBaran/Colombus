using System.Collections;
using UnityEngine;

namespace Colombus.Environment
{
    public class MonoEntity : MonoBehaviour
    {
        public virtual Vector3 ShiftObject(Vector3 sourcePos, Vector3 dir, float speed)
        {
            sourcePos += dir * speed * Time.deltaTime;
            return sourcePos;
        }
    }
}