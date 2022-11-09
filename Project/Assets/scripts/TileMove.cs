using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TileMove : MonoBehaviour
{
    [SerializeField] private Transform emptySpace = null;
    [SerializeField] private int dist = 20;
    [SerializeField] private Transform[] CurrentTilePos;
    [SerializeField] private TextMeshProUGUI TimeText;
    [SerializeField] private int Num_Swaps = 21;
    [SerializeField] private Animator FinishAnim;
    [SerializeField] private TextMeshProUGUI FinishText;
    [SerializeField] private TextMeshProUGUI HighScoreText;
    [SerializeField] private bool win = false;
    [SerializeField] private GameObject Frame;
    [SerializeField] private AudioSource Tile_Sound;
    [SerializeField] private Button NextButton;

    private int ClockTime = -23;
    private bool Clock_work = true;
    private Camera Maincamera;
    private static bool Inti;
    private static bool saved = false;

    private void Start()
    {
        NextButton.interactable = false;
        Inti = true;
        Frame.SetActive(false);
        FinishAnim.enabled = false;
        Inti = true;
        Maincamera = Camera.main;
        Play();
        StartCoroutine(Clock());
    }
    
    private void Update()
    {
        if (Inti == false) 
            if (Winchk()||win)
            {
                Clock_work = false;
                Frame.SetActive(true);
                //Win = true
                //SendMessage(Finish, ClockTime);
                FinishAnim.enabled = true;
                FinishText.text = TimeText.text;
                NextButton.interactable = true;
                if(!saved)
                {
                    EventManager.WriteFile(ClockTime.ToString());
                    saved = true;
                }
                else
                {
                    int highscore = EventManager.ReadFile();
                    if (highscore > ClockTime) highscore = ClockTime;
                    EventManager.CleanFile();
                    EventManager.WriteFile(highscore.ToString());
                    TimeToText(highscore, HighScoreText);
                }

            }

        if ( Input.GetMouseButtonDown(0) && !(Winchk()||win) )
        {
            Ray ray = Maincamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D Hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (Hit)
            {
                if(Vector2.Distance(emptySpace.position, Hit.transform.position) < dist)
                {
                    if(Tile_Sound.clip !=null) Tile_Sound.Play();
                    Vector3 EmptySpacePosition = emptySpace.position;
                    emptySpace.position = Hit.transform.position;
                    Hit.transform.position = EmptySpacePosition;
                }
            }
        }
    }

    private bool Winchk()
    {
        for (int i = 0; i < CurrentTilePos.Length; i++)
        {
            if(CurrentTilePos[i].localPosition.x > 4 || CurrentTilePos[i].localPosition.y > 4 )
            {
                //Win == false;
                return false;
            }
        }
        return true;
    }

    private void Swap(Transform p1, Transform p2)
    {
        Vector2 posp1 = p1.position;
        Vector2 posp2 = p2.position;
        p1.position = posp2;
        p2.position = posp1;
    }

    private void Play()
    {
        //randomize tiles
        int n = Random.Range(0, Num_Swaps+1);
        for(int i = 0; i < n; i++)
        {
            Transform p1 = CurrentTilePos[Random.Range(0, 9)];
            Transform p2 = CurrentTilePos[Random.Range(0, 9)];
            Swap(p1,p2);
        }
        if (Winchk())
        {
            Play();
            Debug.Log("error in random");
        }
        else Inti = false;
    }


    IEnumerator Clock()
    {
        while (Clock_work)
        {
            yield return new WaitForSeconds(1);
            if(Clock_work) ClockTime ++;
            TimeToText(ClockTime, TimeText);
        }
    }

    private void TimeToText(int TimeValue, TextMeshProUGUI TextBox)
    {
        int min = TimeValue / 60;
        int hour = min / 60;
        int sec = TimeValue % 60;
        string strhour = hour.ToString();
        string strmin = min.ToString();
        string strsec = sec.ToString();
        if (hour < 10) strhour = "0" + strhour;
        if (min < 10) strmin = "0" + strmin;
        if (sec < 10) strsec = "0" + strsec;
        if (hour == 0) TextBox.text = strmin + ":" + strsec;
        else TextBox.text = strhour + ":" + strmin + ":" + strsec;
    }
}
