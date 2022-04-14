using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDied : MonoBehaviour
{
    public int zombiekill;

    private void Start()
    {
        zombiekill = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(zombiekill);
        Debug.Log("You collided");
    }
}
