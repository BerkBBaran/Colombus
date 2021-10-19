using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Colombus.Environment
{
    public class SeaRepeater : MonoEntity
    {
        [SerializeField] private EntityShiftingSettings _settings;

        private List<Transform> _seaList = new List<Transform>();

        [SerializeField] private float _changePoint = -15f;

        private void Initiliaze()
        {
            _seaList.Add(transform.GetChild(0));
            _seaList.Add(transform.GetChild(1));

        }

        private void Start()
        {
            Initiliaze();
        }

        private void Update()
        {
            foreach (Transform sea in _seaList)
            {
                sea.position = ShiftObject(sea.position, Vector3.down, _settings.ShiftingSpeed);
            }
            CheckForSwap(_seaList[0].position.y);
        }

        public override Vector3 ShiftObject(Vector3 sourcePos, Vector3 dir, float speed)
        {
            return base.ShiftObject(sourcePos, dir, speed);
        }

        private void CheckForSwap(float yVal)
        {
            if (yVal < _changePoint)
            {
                ChangeObjects();
            }
        }

        private void ChangeObjects()
        {
            Vector2 tempPos = _seaList[1].position;
            tempPos += new Vector2(0, 20);
            _seaList[0].position = tempPos;

            Transform tempSea = _seaList[0];
            _seaList[0] = _seaList[1];
            _seaList[1] = tempSea;
        }
    }
}