using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Colombus.Inputs;

namespace Colombus.PlayerControls
{
    public class PlayerMovementController : MonoBehaviour
    {
        //serilaze from editor
        [SerializeField] private ScriptableInputData _inputData;
        [SerializeField] private PlayerMovementSettings _movementSettings;

        //private field
        private Rigidbody2D rb;
        private Vector2 _movement;
        private float defaultY;

        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            rb = GetComponent<Rigidbody2D>();
            defaultY = transform.position.y;
        }

        private void FixedUpdate()
        {              
            Move();
        }

        private void Move()
        {
            _movement = Vector2.zero;

            if (_inputData.Horizontal != 0)
                _movement += HorizontalVector();

            if (_inputData.Space > 0)
                _movement += BoostVector();
            else if (transform.position.y > defaultY)
                _movement += DragDownVector();


            rb.MovePosition(rb.position + _movement);

            
        }
        private Vector2 BoostVector()
        {
            Vector2 movement = Vector2.up * _movementSettings.BoostSpeed * _inputData.Space;
            return movement;
         
        }
        private Vector2 HorizontalVector()
        {
            Vector2 movement = Vector2.right * _movementSettings.MovementSpeed * _inputData.Horizontal;
            return movement;

        }


        private Vector2 DragDownVector()
        {
            Vector2  movement = Vector2.down * _movementSettings.DragDownSpeed;
            return movement;
        }
    }
}