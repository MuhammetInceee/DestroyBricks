using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DestroyBricks.Controller
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerControllerSettings _playerControllerSettings;

        private float _borderLine = 1.5f;
        private void Update()
        {
            Move();
            Limitation();
        }

        private void Move()
        {
            float _myhorizontal = Input.GetAxis("Horizontal");
            transform.Translate(Vector2.right * Time.deltaTime * _playerControllerSettings._speed * _myhorizontal);
        }

        private void Limitation()
        {
            if(transform.position.x > _borderLine)
            {
                transform.position = new Vector3(_borderLine, transform.position.y, transform.position.z);
            }
            else if(transform.position.x < -_borderLine)
            {
                transform.position = new Vector3(-_borderLine, transform.position.y, transform.position.z);
            }
        }
    }
}
