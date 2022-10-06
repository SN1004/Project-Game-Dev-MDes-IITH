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
    //[SerializeField] Text StartBtnText;
    [SerializeField] Texture2D Cursor_onbutton;
    [SerializeField] Vector2 Hotspot_onbutton;
    [SerializeField] Texture2D Cursor_normal;
    [SerializeField] Vector2 Hotspot_normal;
    [SerializeField] float Force = 10.0f;
    [SerializeField] GameObject Fireanim;
    [SerializeField] int Explosionwait = 10;
    [SerializeField] Rigidbody Testtube;
    [SerializeField] Rigidbody Cork;

    void Start()
    {
        Fireanim.SetActive(false);
    }

    public void FireStart()
    {
        Fireanim.SetActive(true);
        StartCoroutine(ExplosiveWait());
    }

    IEnumerator ExplosiveWait()
    {
        yield return new WaitForSeconds(Explosionwait);
        Explosion();
    }

    private void Explosion()
    {
        Testtube.useGravity = true;
        Testtube.isKinematic = false;
        Cork.useGravity = true;
        Cork.isKinematic = false;
        Testtube.AddRelativeForce((new Vector3(0, 0, -1)) * Force, ForceMode.Impulse);
        Cork.AddRelativeForce((new Vector3(0, 1, 0)) * Force, ForceMode.Impulse);
    }


    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit(){
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }

    /*public void Startbtn(){
        string msg = StartBtnText.text;
        if(msg == "START"){
            msg = "STOP";
            StartBtnText.text = msg;
        }
        else if(msg == "STOP"){
            msg ="START";
            StartBtnText.text = msg;
        }
    }*/
    public void MouseOnButtonEnter(){
        Cursor.SetCursor(Cursor_onbutton, Hotspot_onbutton, CursorMode.Auto);
    }

     public void MouseOnButtonExit(){
        Cursor.SetCursor(Cursor_normal, Hotspot_normal, CursorMode.Auto);
     }
}
