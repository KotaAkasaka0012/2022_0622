using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChenjiScene : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("TopScene");
    }
}
