using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    //private Animator animator;
    private bool isHopping;
    public Text countText;
    private int count;
    private void Start()
    {
        //animator = GetComponent<Animator>();
        count = 0;
        SetCountText();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) //&& !isHopping)
        {
            //animator.SetTrigger("hop");
            //isHopping = true;
            float zDiff = 0;
            count++;
            SetCountText();
            if (transform.position.z % 1 != 0)
            {
                zDiff = (transform.position.z - Mathf.Round(transform.position.z) - transform.position.z);
            }
            MoveCharacter(new Vector3(1, 0, zDiff));
        }
        else if (Input.GetKeyDown(KeyCode.A)) // && !isHopping)
        {
            MoveCharacter(new Vector3(0, 0, 1));
        }
        else if (Input.GetKeyDown(KeyCode.S)) // && !isHopping)
        {
            MoveCharacter(new Vector3(-1, 0, 0));
            count--;
            SetCountText();
        }
        else if (Input.GetKeyDown(KeyCode.D)) // && !isHopping)
        {
            MoveCharacter(new Vector3(0, 0, -1));
        }
    }
    private void MoveCharacter(Vector3 difference)
    {
        //animator.SetTrigger("hop");
        isHopping = true;
        transform.position = (transform.position + difference);
    }
    public void FinishHop()

    {
        isHopping = false;
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
}
