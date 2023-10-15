using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogDelay = 10.0f;

    // Update is called once per frame
    void Update()
    {
        dogDelay -= 0.1f;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogDelay <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogDelay = 10.0f;
        }
    }
}
