using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    
    public void OnBackButtonPressed()
    {
        
        SceneManager.LoadScene("MenuTry"); 
    }

    public void loadintro()
    {
        
        SceneManager.LoadScene("IntroPage"); 
    }
}
