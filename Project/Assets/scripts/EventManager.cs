using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class EventManager : MonoBehaviour
{
    [SerializeField] Texture2D Cursor_onbutton;//To change cursor texture with use of event trigger
    [SerializeField] Vector2 Hotspot_onbutton;
    [SerializeField] Texture2D Cursor_normal;
    [SerializeField] Vector2 Hotspot_normal;
    // For camera movement
/*    [SerializeField] Vector2 Max;     
    [SerializeField] Vector2 Min;*/    
    [SerializeField] List<SceneAsset> OrderedScenes;
    private static int scenecount=0;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        /*DontDestroyOnLoad(this);
        SceneManager.LoadScene(OrderedScenes[scenecount].name);*/
    }

    public void Back()
    {
        /*SceneManager.LoadScene("Level_Select");*/
    }

    public void Next()
    {
      /*  DontDestroyOnLoad(this);
        scenecount += 1;
        SceneManager.LoadScene(OrderedScenes[scenecount].name);*/
    }

    public void Home()
    {
        /*SceneManager.LoadScene("Home");*/
    }

    public void Quit()
    {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }

    public void MouseOnButtonEnter()
    {
        Cursor.SetCursor(Cursor_onbutton, Hotspot_onbutton, CursorMode.Auto);
    }

     public void MouseOnButtonExit()
     {
        Cursor.SetCursor(Cursor_normal, Hotspot_normal, CursorMode.Auto);
     }
}
