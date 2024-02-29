using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //UpdategameState(GameState.Tutorial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum GameState
    {
        Tutorial,
        Baseline,
        SadnessScenario,
        DisgustScenario,
        HappyScenario,
        FearScenario
    }
}
