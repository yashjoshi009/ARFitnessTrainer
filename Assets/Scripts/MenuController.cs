using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    public void LoadFitnessScene()
    {
        SceneManager.LoadScene("Fitness");
        
    }

    public void LoadMMAScene()
    {
        SceneManager.LoadScene("MMA");
        
    }

    

    public void LoadAboutUsScene()
    {
        SceneManager.LoadScene("AboutUs");
        
    }

    public void LoadMainmenu()
    {
        
        SceneManager.LoadScene("MenuTry");
        
    }
}
