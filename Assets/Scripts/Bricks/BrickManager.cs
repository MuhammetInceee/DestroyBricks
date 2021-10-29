using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DestroyBricks.Bricks
{
    public class BrickManager : MonoBehaviour
    {

        public int _health;
        public Text _healthText;


        public virtual void DestroyOnZeroHealth()
        {
            if (_health <= 0)
            {
                Destroy(gameObject);
                Destroy(_healthText);
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == 7)
            {
                _health--;
            }
        }
    }
}