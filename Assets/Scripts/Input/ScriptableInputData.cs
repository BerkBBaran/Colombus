using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Colombus.Inputs
{
    [CreateAssetMenu(fileName = "InputData", menuName = "Input/New Input Data")]
    public class ScriptableInputData : ScriptableObject
    {
        [SerializeField] private float _horizontal;
        public float Horizontal { get => _horizontal; private set => _horizontal = value; }

        //[SerializeField] private float _vertical;
        //public float Vertical { get => _vertical; private set => _vertical = value; }

        public void ProcessInput()
        {
            Horizontal = Input.GetAxisRaw("Horizontal");
            //Vertical = Input.GetAxis("Vertical");
        }
    }
}