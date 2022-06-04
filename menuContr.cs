using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuContr : MonoBehaviour
{
    string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        sceneName=SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            PlayerPrefs.SetString("nameLevel",sceneName);
            SceneManager.LoadScene("Menu");
        }
    }
    public void GameStart(){
        SceneManager.LoadScene("Game");
    }
    public void ContinueGame(){
        SceneManager.LoadScene(PlayerPrefs.GetString("nameLevel"));
    }
}
