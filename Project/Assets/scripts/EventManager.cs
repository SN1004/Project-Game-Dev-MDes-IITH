using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class EventManager : MonoBehaviour
{
    [SerializeField] private Texture2D Cursor_onbutton;//To change cursor texture with use of event trigger
    [SerializeField] private Vector2 Hotspot_onbutton;
    [SerializeField] private Texture2D Cursor_normal;
    [SerializeField] private Vector2 Hotspot_normal;
    [SerializeField] private AudioSource Button_Sound;

    // For camera movement
    /*    [SerializeField] Vector2 Max;     
        [SerializeField] Vector2 Min;*/
    [SerializeField] List<SceneAsset> OrderedScenes;
    private static int scenecount=0;

    public void Restart()
    {
        Button_Sound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        /*DontDestroyOnLoad(this);
        SceneManager.LoadScene(OrderedScenes[scenecount].name);*/
    }

    public void Back()
    {
        Button_Sound.Play();
        /*SceneManager.LoadScene("Level_Select");*/
    }

    public void Next()
    {
        Button_Sound.Play();
        /*  DontDestroyOnLoad(this);
          scenecount += 1;
          SceneManager.LoadScene(OrderedScenes[scenecount].name);*/
    }

    public void Home()
    {
        Button_Sound.Play();
        /*SceneManager.LoadScene("Home");*/
    }

    public void Quit()
    {
        Button_Sound.Play();
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

    public static void WriteFile(string text)
    {
        string path = "Assets/level 2_/highscore.txt";
        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(text);
        writer.Close();
        /*//Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load(path);
        //Print the text from the file
        Debug.Log(asset.text);*/
    }
    public static int ReadFile()
    {
        string text;
        string path = "Assets/level 2_/highscore.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        text = reader.ReadLine();
        reader.Close();
        int time = int.Parse(text);
        return time;
    }
    public static void CleanFile()
    {
        string path = "Assets/level 2_/highscore.txt";
        File.WriteAllText(path, "");
    }
}
