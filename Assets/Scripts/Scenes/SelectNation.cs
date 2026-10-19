using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectNation : MonoBehaviour
{
    [SerializeField]
    private string nextScene = "Map01";

    [SerializeField]
    private int index = 0;

    public void SelectEuropeNation(int i)
    {
        index = i;
        Settings.playerNationId = index;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        SceneManager.LoadScene(nextScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
