using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DestroyBricks.Ball
{
    public class Ball : MonoBehaviour
    {
        private Rigidbody2D _ballRb;
        private bool _isGameStarted = false;
        [SerializeField] private BallSettings _ballSettings;
        void Start()
        {
            _ballRb = GetComponent<Rigidbody2D>();
        }


        void Update()
        {
            OnPlay();
        }

        void OnPlay()
        {
            StartHop();
            if (_isGameStarted)
            {
                ConstantSpeed();
            }
        }

        void StartHop()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _ballRb.AddForce(Vector3.up);
                _isGameStarted = true;
                _ballRb.constraints = RigidbodyConstraints2D.None;
                _ballRb.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }

        void ConstantSpeed()
        {
            var cvel = _ballRb.velocity;
            var tvel = cvel.normalized * _ballSettings._constantSpeed;
            _ballRb.velocity = Vector3.Lerp(cvel, tvel, Time.deltaTime * _ballSettings._smoothingFactor);
        }
    }
}