using System.Collections;
using UnityEngine;

namespace Colombus.Inputs
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private ScriptableInputData _inputData;

        private void Update()
        {
            _inputData.ProcessInput();
        }
    }
}