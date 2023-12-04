using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kolize : MonoBehaviour
{
    public int level = 0;
    public int colected = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BadWall"))
        {
            Time.timeScale = 0f;

        }
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            colected++;
        }
        if (other.gameObject.CompareTag("finish"))
        {
            if (colected == 1)
            {
                level++;
                Time.timeScale = 0f;
                SceneManager.LoadScene(level);

            }
        }
    }
}
