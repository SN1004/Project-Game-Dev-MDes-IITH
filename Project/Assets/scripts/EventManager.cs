using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

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
    [SerializeField] private VideoPlayer Video;
    [SerializeField] private Sprite Play, Pause;
    [SerializeField] private Image PlayPauseButton;
    // For camera movement
    /*    [SerializeField] Vector2 Max;     
        [SerializeField] Vector2 Min;*/
    public static bool Level2Open = false;
    private GameObject Level2SelectButton;
    

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "LevelSelect")
        {
            Level2SelectButton = GameObject.FindGameObjectWithTag("GameCanvas");
            Level2SelectButton.GetComponent<Button>().interactable = Level2Open;
        }
    }

    public void PlayPauseFunction()
    {
        if (Video != null)
            if (Video.isPlaying)
            {
                PlayPauseButton.sprite = Pause;
                Video.Pause();
            }
            else
            {
                PlayPauseButton.sprite = Play;
                Video.Play();
            }
    }

    public static void LoadScene2()
    {
        SceneManager.LoadScene("Scene2");
    }

    public static void LoadLevel1()
    {
        SceneManager.LoadScene("level1");
    }

    public void BackHome()
    {
        SceneManager.LoadScene("Home");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void Level1Select()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Level2Select()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Back()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void Next()
    {
        SceneManager.LoadScene("Ending");
    }

    public void Home()
    {
        SceneManager.LoadScene("Home");
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

    private static string DataPath()
    {
        return Application.persistentDataPath + "/highscore.txt";
    }

    public static void WriteFile(string text)
    {
        string path = DataPath();
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
        string path = DataPath();
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        text = reader.ReadLine();
        reader.Close();
        int time = int.Parse(text);
        return time;
    }
    public static void CleanFile()
    {
        string path = DataPath();
        File.WriteAllText(path, "");
    }
}
