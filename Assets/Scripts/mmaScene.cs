using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mmaScene : MonoBehaviour
{
    
    public void LoadPunchScene()
    {
        SceneManager.LoadScene("Punch");
        
    }

    public void LoadKickScene()
    {
        SceneManager.LoadScene("Kicks");
        
    }
    
    public void LoadComboScene()
    {
        SceneManager.LoadScene("Combo");
        
    }

    public void LoadMMAScene()
    {
        SceneManager.LoadScene("MMA");
        
    }
}
