using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{
    public GameObject scrollbar;
    //public GameObject L, R;
    public HandleButton left;
    public HandleButton right;
    private float scroll_pos = 0;
    private int child = 0;
    float[] pos;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        }
        else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
                {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
                }
            }
        }


        for (int i = 0; i < pos.Length; i++)
        {
            if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
            {
                Debug.LogWarning("Current Selected Level" + i);
                transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1.2f, 1.2f), 0.1f);
                for (int j = 0; j < pos.Length; j++)
                {
                    if (j != i)
                    {
                        transform.GetChild(j).localScale = Vector2.Lerp(transform.GetChild(j).localScale, new Vector2(0.8f, 0.8f), 0.1f);
                    }
                }
            }
        }*/
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }
        print(pos.Length);
        /*if (left.clicked)
        {
            if (child > 0)
            {
                child -= 60;
            }
            scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[child], 0.1f);
        }
        if (right.clicked)
        {
            child+= 60;
            scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[child], 0.1f);
        }*/
        scrollbar.GetComponent<Scrollbar>().gameObject.SetActive(false);
        if (left.clicked)
        {
            if(child > 0)
            {
                scrollbar.GetComponent<Scrollbar>().gameObject.SetActive(true);
                child--;
                scrollbar.GetComponent<Scrollbar>().value = pos[child];
                scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
                //print(scroll_pos);
            }
        }
        if (right.clicked) 
        {
            if (child < pos.Length-1)
            {
                scrollbar.GetComponent<Scrollbar>().gameObject.SetActive(true);
                child++;
                scrollbar.GetComponent<Scrollbar>().value = pos[child];
                scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
                print(scroll_pos);
            }
        }
       /* for (int i = 0; i < pos.Length; i++)
        {
            if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
            }
        }*/
        
        for (int i = 0; i < pos.Length; i++)
        {
            if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
            {
                Debug.LogWarning("Current Selected Level" + i);
                transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1.5f, 1.5f), 0.1f);
                for (int j = 0; j < pos.Length; j++)
                {
                    if (j != i)
                    {
                        transform.GetChild(j).localScale = Vector2.Lerp(transform.GetChild(j).localScale, new Vector2(0.6f, 0.6f), 0.1f);
                    }
                }
            }
        }
        
    }
    
}