using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int gold;
    public bool playerAlive;
    public Text goldText;
    public Text tutorialText;

    #region Singleton code
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to instantiate a second" +
                "instance of singleton Game Manager");
        }
    }
    #endregion

    void Start()
    {
        gold = 0;
        playerAlive = true;
    }

    void Update()
    {
        if (!playerAlive)
        {
            tutorialText.text = "You Died! Press 'R' to restart";

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        goldText.text = "Gold: " + gold;
    }
}
