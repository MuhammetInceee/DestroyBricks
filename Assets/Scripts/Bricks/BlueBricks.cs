using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DestroyBricks.Bricks
{
    public class BlueBricks : BrickManager
    {

        private void Update()
        {
            _healthText.text = "" + _health;
            DestroyOnZeroHealth();
        }
    }
}