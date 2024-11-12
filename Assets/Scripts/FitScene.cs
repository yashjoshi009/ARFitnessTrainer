using UnityEngine;
using UnityEngine.SceneManagement;

public class FitScene : MonoBehaviour
{
    
    public void LoadCoreScene()
    {
        SceneManager.LoadScene("Core");
        
    }

    public void LoadFreeScene()
    {
        SceneManager.LoadScene("Free");
        
    }

    

    public void LoadPowerScene()
    {
        SceneManager.LoadScene("Power");
        
    }

    public void LoadStrengthScene()
    {
        
        SceneManager.LoadScene("Strength");
        
    }

    public void LoadFitnessScene()
    {
        
        SceneManager.LoadScene("Fitness");
        
    }
}
