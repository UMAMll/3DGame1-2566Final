using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Gamekit3D
{
    public class SetCursorMode : MonoBehaviour
    {
        public bool visible = true;
        public CursorLockMode lockMode = CursorLockMode.None;

        void Start()
        {
            Cursor.visible = visible;
            Cursor.lockState = lockMode;
        }

        public void SetMode(bool VisibleMode)
        {
            visible = VisibleMode;
            Cursor.visible = visible;
            Cursor.lockState = lockMode;
        }
    }
}