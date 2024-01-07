using UnityEngine.SceneManagement;
using UnityEngine;

public class c : MonoBehaviour
{
    // Start is called before the first frame update
   public void NewGame()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;

        // Đóng scene hiện tại và xóa khỏi bộ nhớ
        SceneManager.UnloadSceneAsync(currentIndex);
        SceneManager.LoadScene("MainScene");
    }

    // Update is called once per frame
   public void QuitGame()
{
    // save any game data here
    #if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
}
        
    
}
