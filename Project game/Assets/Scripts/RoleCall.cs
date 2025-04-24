using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoleCall : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject F;
    public GameObject G;
    public GameObject H;

    public int time;
    public int realMinutes;
    public int realSeconds;
    public int timerSeconds=0;
    public int inGameHour;
    public int inGameMinute;
    public List<GameObject> alive;
    void Awake()
    {

        int killer = Random.Range(0, 8);

        switch (killer)
        {
            case 0:
                A.tag = "Untagged";
                
                break;
            case 1:
                B.tag = "Untagged";
                
                break;
            case 2:
                C.tag = "Untagged";
                
                break;
            case 3:
                D.tag = "Untagged";
                
                break;
            case 4:
                E.tag = "Untagged";
                
                break;
            case 5:
                F.tag = "Untagged";
                
                break;
            case 6:
                G.tag = "Untagged";
                
                break;
            default:
                H.tag = "Untagged";
                
                break;
        }

    }

    private void Start()
    {
        alive.Add(A);
        alive.Add(B);
        alive.Add(C);
        alive.Add(D);
        alive.Add(E);
        alive.Add(F);
        alive.Add(G);
        alive.Add(H);
    }
    private void FixedUpdate()
    {
        Timer();
        Alive();
    }

    public void Timer() {

        

        if (alive.Count == 0)
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            time++;
            if (time >= 51) {
                timerSeconds++;
                realMinutes = Mathf.Floor(timerSeconds / 60).ConvertTo<int>();
                realSeconds = timerSeconds - realMinutes * 60;
                time = 0;
            }
        }

        if (realMinutes == 60)
        {
            SceneManager.LoadScene(3);
        }
    }

    void Alive() {
        if (A.tag != "Suspect") { 
            alive.Remove(A);
        }
        if (B.tag != "Suspect")
        {
            alive.Remove(B);
        }
        if (C.tag != "Suspect")
        {
            alive.Remove(C);
        }
        if (D.tag != "Suspect")
        {
            alive.Remove(D);
        }
        if (E.tag != "Suspect")
        {
            alive.Remove(E);
        }
        if (F.tag != "Suspect")
        {
            alive.Remove(F);
        }
        if (G.tag != "Suspect")
        {
            alive.Remove(G);
        }
        if (H.tag != "Suspect")
        {
            alive.Remove(H);
        }


        
    }
}
