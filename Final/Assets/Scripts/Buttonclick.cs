using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonclick : MonoBehaviour
{
    public string SceneToLoad;
    public Vector3 playerposition;
    public Vactor3volue playerStorage;
    public void ONClick()
    {
        playerStorage.initiavalue = playerposition;
        SceneManager.LoadScene(SceneToLoad);
    }
}
