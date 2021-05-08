using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Boss boss1;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void killBoss()
    {
        boss1.onKill();
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
