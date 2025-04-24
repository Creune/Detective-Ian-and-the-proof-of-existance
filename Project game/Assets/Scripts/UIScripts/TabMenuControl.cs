using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabMenuControl : MonoBehaviour
{

    public GameObject alfred;
    public GameObject brad;
    public GameObject chris;
    public GameObject david;
    public GameObject evan;
    public GameObject freddy;
    public GameObject george;
    public GameObject henry;

    public RoleCall roleCall;
    private GameObject personPanel;
    private GameObject namePanel;

    void Start()
    {
        personPanel = gameObject.transform.GetChild(0).gameObject;
        namePanel=gameObject.transform.GetChild(1).GetChild(0).gameObject;

        SetStart();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckDead();
    }

    void SetStart() {
        personPanel.transform.GetChild(0).GetComponent<Image>().sprite = alfred.GetComponent<SpriteRenderer>().sprite;
        personPanel.transform.GetChild(0).GetComponent<Image>().color = alfred.GetComponent<SpriteRenderer>().color;
        namePanel.transform.GetChild(1).GetComponent<Text>().text = alfred.gameObject.name;

        personPanel.transform.GetChild(1).GetComponent<Image>().sprite = brad.GetComponent<SpriteRenderer>().sprite;
        personPanel.transform.GetChild(1).GetComponent<Image>().color = brad.GetComponent<SpriteRenderer>().color;
        namePanel.transform.GetChild(2).GetComponent<Text>().text = brad.gameObject.name;

        personPanel.transform.GetChild(2).GetComponent<Image>().sprite = chris.GetComponent<SpriteRenderer>().sprite;
        personPanel.transform.GetChild(2).GetComponent<Image>().color = chris.GetComponent<SpriteRenderer>().color;
        namePanel.transform.GetChild(3).GetComponent<Text>().text = chris.gameObject.name;

        personPanel.transform.GetChild(3).GetComponent<Image>().sprite = david.GetComponent<SpriteRenderer>().sprite;
        personPanel.transform.GetChild(3).GetComponent<Image>().color = david.GetComponent<SpriteRenderer>().color;
        namePanel.transform.GetChild(4).GetComponent<Text>().text = david.gameObject.name;

        personPanel.transform.GetChild(4).GetComponent<Image>().sprite = evan.GetComponent<SpriteRenderer>().sprite;
        personPanel.transform.GetChild(4).GetComponent<Image>().color = evan.GetComponent<SpriteRenderer>().color;
        namePanel.transform.GetChild(5).GetComponent<Text>().text = evan.gameObject.name;

        personPanel.transform.GetChild(5).GetComponent<Image>().sprite = freddy.GetComponent<SpriteRenderer>().sprite;
        personPanel.transform.GetChild(5).GetComponent<Image>().color = freddy.GetComponent<SpriteRenderer>().color;
        namePanel.transform.GetChild(6).GetComponent<Text>().text = freddy.gameObject.name;

        personPanel.transform.GetChild(6).GetComponent<Image>().sprite = george.GetComponent<SpriteRenderer>().sprite;
        personPanel.transform.GetChild(6).GetComponent<Image>().color = george.GetComponent<SpriteRenderer>().color;
        namePanel.transform.GetChild(7).GetComponent<Text>().text = george.gameObject.name;

        personPanel.transform.GetChild(7).GetComponent<Image>().sprite = henry.GetComponent<SpriteRenderer>().sprite;
        personPanel.transform.GetChild(7).GetComponent<Image>().color = henry.GetComponent<SpriteRenderer>().color;
        namePanel.transform.GetChild(8).GetComponent<Text>().text = henry.gameObject.name;
    }

    void CheckDead() {
        if (alfred.GetComponent<BodyController>().bodyFound) {
            Color c = personPanel.transform.GetChild(0).GetComponent<Image>().color;
            c.a = 0.3f;
            personPanel.transform.GetChild(0).GetComponent<Image>().color = c;
        }

        if (brad.GetComponent<BodyController>().bodyFound)
        {
            Color c=personPanel.transform.GetChild(1).GetComponent<Image>().color;
            c.a = 0.3f;
            personPanel.transform.GetChild(1).GetComponent<Image>().color = c;
        }

        if (chris.GetComponent<BodyController>().bodyFound)
        {
            Color c = personPanel.transform.GetChild(2).GetComponent<Image>().color;
            c.a = 0.3f;
            personPanel.transform.GetChild(2).GetComponent<Image>().color = c;
        }

        if (david.GetComponent<BodyController>().bodyFound)
        {
            Color c = personPanel.transform.GetChild(3).GetComponent<Image>().color;
            c.a = 0.3f;
            personPanel.transform.GetChild(3).GetComponent<Image>().color = c;
        }

        if (evan.GetComponent<BodyController>().bodyFound)
        {
            Color c = personPanel.transform.GetChild(4).GetComponent<Image>().color;
            c.a = 0.3f;
            personPanel.transform.GetChild(4).GetComponent<Image>().color = c;
        }

        if (freddy.GetComponent<BodyController>().bodyFound)
        {
            Color c = personPanel.transform.GetChild(5).GetComponent<Image>().color;
            c.a = 0.3f;
            personPanel.transform.GetChild(5).GetComponent<Image>().color = c;
        }

        if (george.GetComponent<BodyController>().bodyFound)
        {
            Color c = personPanel.transform.GetChild(6).GetComponent<Image>().color;
            c.a = 0.3f;
            personPanel.transform.GetChild(6).GetComponent<Image>().color = c;
        }

        if (henry.GetComponent<BodyController>().bodyFound)
        {
            Color c = personPanel.transform.GetChild(7).GetComponent<Image>().color;
            c.a = 0.3f;
            personPanel.transform.GetChild(7).GetComponent<Image>().color = c;
        }
    }


}
