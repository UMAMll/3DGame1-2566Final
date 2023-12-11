using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class SceneNotJump : MonoBehaviour
    {
        void Start()
        {
            PlayerController.instance.m_ReadyToJump = false;
            PlayerController.instance.m_IsGrounded = false;
            PlayerInput.Instance.m_Jump = false;
        }
    }
}
