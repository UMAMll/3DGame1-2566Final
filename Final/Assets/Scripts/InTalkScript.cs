using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class InTalkScript : MonoBehaviour
    {
        public bool m_InTalk = false;
        
        public void SetTalk(bool intalk)
        {
            m_InTalk = intalk;
        }

        public void TalkScene()
        {
            Cursor.lockState = !m_InTalk ? CursorLockMode.Locked : CursorLockMode.None;
            Cursor.visible = m_InTalk;

            if (m_InTalk)
                PlayerInput.Instance.ReleaseControl();
            else
                PlayerInput.Instance.GainControl();

        }

        public void OnPoint()
        {
            Cursor.lockState = !m_InTalk ? CursorLockMode.Locked : CursorLockMode.None;
            Cursor.visible = m_InTalk;

        }

        public void EndTalk()
        {
            Cursor.lockState = true ? CursorLockMode.Locked : CursorLockMode.None;
            Cursor.visible = false;
            PlayerInput.Instance.GainControl();
        }
    }
}

