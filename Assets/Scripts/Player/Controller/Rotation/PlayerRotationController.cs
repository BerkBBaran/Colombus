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
            Rotate();
        }
        private void Rotate()
        {
            Quaternion currentQua =Quaternion.Euler(0, 0, rb.rotation);
            Quaternion targetQua = (_inputData.Horizontal < 0) ? Quaternion.Euler(Vector3.forward * _rotationSettings.DegreeLimit) :
                Quaternion.Euler(Vector3.forward * -_rotationSettings.DegreeLimit);
            if (_inputData.Horizontal == 0)
                targetQua = Quaternion.Euler(Vector3.zero);

            rb.MoveRotation(Quaternion.Lerp(currentQua, targetQua,Time.fixedDeltaTime * _rotationSettings.RotationSpeed));

        }
       

    }
}