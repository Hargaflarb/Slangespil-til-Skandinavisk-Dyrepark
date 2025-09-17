using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManaging : MonoBehaviour
{
    #region Fields
    //make sure these are the same as the scene names, at least in the editor
    [Header("Main scene")]
    [SerializeField]
    [Tooltip("No switch for this one, Main Scene is what holds everything else, so should always be activated.")]
    private string mainSceneName = "Main Game";
    [Header ("Menu")]
    [SerializeField]
    private string mainMenuSceneName = "Main menu";
    [SerializeField]
    private bool activateMainMenu = false;
    [Header("UI")]
    [SerializeField]
    private string uiSceneName = "UI";
    [SerializeField]
    private bool activateUI = true;
    [Header("Sorting minigame")]
    [SerializeField]
    private string sortingGameSceneName = "Sorting minigame";
    [SerializeField]
    private bool activateSortingGame = false;
    [Header("Menu")]
    [SerializeField]
    private string inputTestSceneName = "input test";
    [SerializeField]
    private bool activateInputTest = false;

    #endregion
    #region Methods
    private IEnumerator Start()
    {
        //load all the scenes you want
        SceneManager.LoadScene(mainSceneName, LoadSceneMode.Additive);
        if (activateMainMenu) 
        {
            SceneManager.LoadScene(mainMenuSceneName, LoadSceneMode.Additive);
        }
        if (activateUI)
        {
            SceneManager.LoadScene(uiSceneName, LoadSceneMode.Additive);
        }
        if (activateSortingGame)
        {
            SceneManager.LoadScene(sortingGameSceneName, LoadSceneMode.Additive);
        }
        if (activateInputTest)
        {
            SceneManager.LoadScene(inputTestSceneName, LoadSceneMode.Additive);
        }

        
        //unload this scene, as it is not needed anymore
        yield return SceneManager.UnloadSceneAsync(gameObject.scene);
    }
    #endregion
}
