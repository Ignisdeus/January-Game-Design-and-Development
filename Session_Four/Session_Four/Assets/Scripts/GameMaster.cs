using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // import scene management

public class GameMaster : MonoBehaviour
{

  
    public void LevelToLoad(int x){

        SceneManager.LoadScene(x); // load scene by index 

    } 


}
