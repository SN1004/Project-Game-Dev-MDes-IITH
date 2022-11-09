using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1End : MonoBehaviour
{
    public void EndingStart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Ending");
    }
}
