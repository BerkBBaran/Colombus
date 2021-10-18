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

        private void Initiliaze()
        {
            rb = GetComponent<Rigidbody2D>();

        }
        private void Awake()
        {
            Initiliaze();
                        
        }
        private void FixedUpdate()
        {
            if (_inputData.Horizontal == 0)
                NotRotating();
            else if (_inputData.Horizontal * rb.rotation > 1)
                InstantRotation();
            else
                Rotate();
        }

        private void Rotate()
        {
            rb.MoveRotation(rb.rotation + _rotationSettings.Speed* Time.fixedDeltaTime*-(_inputData.Horizontal));
        }
        private void NotRotating()
        {
            if (rb.rotation < -1)
                rb.MoveRotation(rb.rotation + _rotationSettings.Speed * Time.fixedDeltaTime *2);
            else if (rb.rotation > 1)
                rb.MoveRotation(rb.rotation + _rotationSettings.Speed * Time.fixedDeltaTime * -2f);
        }
        private void InstantRotation()
        {
            if (rb.rotation < -1)
                rb.MoveRotation(rb.rotation + _rotationSettings.Speed * Time.fixedDeltaTime * 6);
            else if (rb.rotation > 1)
                rb.MoveRotation(rb.rotation + _rotationSettings.Speed * Time.fixedDeltaTime * -6);

        }

    }
}