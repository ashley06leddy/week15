using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

     public GameObject launchFirstButton;

     // Start is called before the first frame
     void Start()
     {
          // Clear selected object
          EventSystem.current.SetSelectedGameObject(null);
          // Set a new selected object
          EventSystem.current.SetSelectedGameObject(launchFirstButton);

     }
     
     public void PlayGame()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   
   public void QuitGame()
   {
        Application.Quit();
        Debug.Log("Quit!");
   }
}
