using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DestroyBricks.Ball 
{
    [CreateAssetMenu(menuName = "DestroyBricks/Ball/Ball Settings")]
    public class BallSettings : ScriptableObject
    {
        public float _constantSpeed = 11f;
        public float _smoothingFactor = 1f;
    }
}