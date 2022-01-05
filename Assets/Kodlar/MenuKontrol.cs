using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{

    public void oyunaGit()
    {
        SceneManager.LoadScene("Level1");
    }
    public void oyundanCik()
    {
        Application.Quit();
    }
}
