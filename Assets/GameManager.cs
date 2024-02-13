using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private float[] sceneDurations = { 15f, 420f, 120f, 420f, 120f, 420f, 120f, 420f, 120f, 420f, 120f, 400f};
    private int[] sceneOrder = { 0, 1, 2, 3, 2, 6, 2, 5, 2, 4, 2, 7};
    private int currentSceneIndex = 0;
    private float sceneTimer = 0;
 


    void Start()
    {
        //LoadSceneByIndex(currentSceneIndex);
    }

    private void Awake()
    {
        //Instantiate(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }

    void FixedUpdate()
    {
            sceneTimer += Time.deltaTime;

            if (sceneTimer >= sceneDurations[currentSceneIndex])
            {
                LoadNextScene();
            }
        
       
    }

    void LoadSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
        sceneTimer = 0;
    }

    public void LoadNextScene()
    {
        currentSceneIndex++;
        if (currentSceneIndex < sceneDurations.Length)
        {
            LoadSceneByIndex(sceneOrder[currentSceneIndex]);
            //SceneManager.UnloadSceneAsync(sceneOrder[currentSceneIndex-1]);
        }

        else
        {
            Application.Quit();
        }
    }


}



    
