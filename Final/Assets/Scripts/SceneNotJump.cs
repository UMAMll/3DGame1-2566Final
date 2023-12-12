using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Gamekit3D
{
    public class SceneNotJump : MonoBehaviour
    {
        public UnityEvent Is_True;
        public static bool CanJump;

        private void FixedUpdate()
        {
            Is_True.Invoke();
        }
        public void SetJump(bool canjump)
        {
            CanJump = canjump;
        }

    }
}
