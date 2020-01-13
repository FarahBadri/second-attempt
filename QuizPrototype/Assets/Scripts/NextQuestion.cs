using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextQuestion : MonoBehaviour
{
    public void LoadQuestion()
    {
        SceneManager.LoadScene("Question2");
    }
}
