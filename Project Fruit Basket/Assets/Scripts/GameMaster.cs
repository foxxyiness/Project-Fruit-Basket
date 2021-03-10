using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    
    void Update()
    {
        if(PlayerHandler.Lives <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
