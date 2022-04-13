using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDied : MonoBehaviour
{
    public int loadscene;

    private void Start()
    {
        loadscene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(loadscene);
    }
}
