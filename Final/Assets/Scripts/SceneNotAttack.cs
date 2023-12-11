using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class SceneNotAttack : MonoBehaviour
    {
        void Start()
        {
            PlayerController.instance.canAttack = false;
        }
    }
}

