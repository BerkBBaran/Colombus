using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Colombus.Inputs
{
    [CreateAssetMenu(fileName = "InputData", menuName = "Input/New Input Data")]
    public class ScriptableInputData : ScriptableObject
    {
        [SerializeField] private float _horizontal;
        [SerializeField] private float _space;

        public float Horizontal { get => _horizontal; private set => _horizontal = value; }
        public float Space { get => _space; private set => _space = value; }
        //[SerializeField] private float _vertical;
        //public float Vertical { get => _vertical; private set => _vertical = value; }

        public void ProcessInput()
        {
            Horizontal = Input.GetAxisRaw("Horizontal");
            Space = Input.GetAxis("Jump");
        }
    }
}