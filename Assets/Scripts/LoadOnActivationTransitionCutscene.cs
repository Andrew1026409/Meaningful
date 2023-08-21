using UnityEngine;
using UnityEngine.SceneManagement;
 
public class LoadOnActivationTransitionCutscene : MonoBehaviour
{
    void OnEnable()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("TransitionCutscene", LoadSceneMode.Single);
    }
}
