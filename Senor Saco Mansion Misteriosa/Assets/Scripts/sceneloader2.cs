// This is one example of code.
// It is a simple scene loader
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader2 : MonoBehaviour
{
    public void LoadNextScene()
    {
        // Current scene index is already camel case.
        // Scene Manager is capitalized because it is a function.
        // Get active scene is capitalized because it is a function
        // Build index has camel case.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        SceneManager.LoadScene(currentSceneIndex + 1);

    }

    // I changed the public for to a serialized field.
    [SerializeField] void LoadNewScene(int sceneNumber)
    
    {
        SceneManager.LoadScene(sceneNumber);
    }
}

