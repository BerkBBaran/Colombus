using System.Collections;
using UnityEngine;
using Colombus.Inputs;

namespace Colombus.PlayerControls
{
    public class PlayerRotationController : MonoBehaviour
    {
        [SerializeField] private ScriptableInputData _inputData;
        [SerializeField] private PlayerRotationSettings _rotationSettings;
        private Rigidbody2D rb;


    }
}