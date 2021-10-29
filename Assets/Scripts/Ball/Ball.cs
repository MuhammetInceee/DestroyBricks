using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DestroyBricks.Ball
{
    public class Ball : MonoBehaviour
    {
        private Rigidbody2D _ballRb;
        [SerializeField] private BallSettings _ballSettings;
        void Start()
        {
            _ballRb = GetComponent<Rigidbody2D>();
        }


        void Update()
        {
            //StartHop();
            ConstantSpeed();
        }

        void StartHop()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _ballRb.AddForce(Vector3.up * Time.deltaTime * 20000);
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