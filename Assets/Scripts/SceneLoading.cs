using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoading : MonoBehaviour
{
    public Button gemScene;

    void Start()
    {

        Button btn = gemScene.GetComponent<Button>();
        btn.onClick.AddListener(SceneChange);


    }

    public void SceneChange()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
        else
            SceneManager.LoadScene(0);
    }
}
