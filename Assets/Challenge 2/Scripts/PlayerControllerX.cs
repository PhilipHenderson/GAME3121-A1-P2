using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // Check if there are any active dog objects in the scene
        GameObject[] dogObjects = GameObject.FindGameObjectsWithTag("Dog");

        // On spacebar press and no active dog objects are found, send a dog
        if (Input.GetKeyDown(KeyCode.Space) && dogObjects.Length == 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
