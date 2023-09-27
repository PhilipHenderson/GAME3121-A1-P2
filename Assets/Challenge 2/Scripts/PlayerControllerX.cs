using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public GameObject gameOverUI;

    public bool isGameRunning;

    void Start()
    {
        gameOverUI.SetActive(false);
        isGameRunning = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (isGameRunning)
        {
            // Check if there are any active dog objects in the scene
            GameObject[] dogObjects = GameObject.FindGameObjectsWithTag("Dog");

            // On spacebar press and no active dog objects are found, send a dog
            if (Input.GetKeyDown(KeyCode.Space) && dogObjects.Length == 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
            gameOverUI.SetActive(false);
            Time.timeScale = 1;
        }
        
    }
}
