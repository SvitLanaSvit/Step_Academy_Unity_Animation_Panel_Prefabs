using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public int indexScene = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Run>() != null)
        {
            SceneManager.LoadScene(indexScene);
        }
    }
}
