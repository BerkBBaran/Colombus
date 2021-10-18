using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Colombus.Inputs;

namespace Colombus.PlayerControls
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private ScriptableInputData _inputData;
        [SerializeField] private PlayerMovementSettings _movementSettings;
        private Rigidbody2D rb;

        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            var movement = Vector2.right * _movementSettings.Speed * _inputData.Horizontal;
            rb.MovePosition(rb.position + movement);
        }
    }
}