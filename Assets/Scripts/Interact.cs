using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

    public bool istouchingbank;
    public bool istouchingbush;
    public bool istouchingFood;
    public int resources;
    public GameObject cCO;
    public bool hidden = false;

    public bool gathering;
    //public Sprite normal;
    public Sprite hiding;
    private SpriteRenderer spriteRenderer;

    Animator anim;

    // Use this for initialization
    void Start()
    {
        resources = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hidden == true)
        {
		//	spriteRenderer.enabled = false;
			//anim.enabled = false;
        }
/*
        if (hidden == false)
        {
            spriteRenderer.sprite = normal;
        }
        */
        if (istouchingbush == true && Input.GetKeyDown(KeyCode.P))
        {
            //Debug.Log("touching and e pressed");
            anim.SetBool("gathering", true);
            gathering = true;
            StartCoroutine(wait());

            // anim.SetBool("gathering", false);
            //cCO.SendMessage("pick");
        }

        if (istouchingFood == true && Input.GetKeyDown(KeyCode.P))
        {
            //Debug.Log("touching and e pressed");
            anim.SetBool("gathering", true);
            gathering = true;
            StartCoroutine(wait());
           
            // anim.SetBool("gathering", false);
            // cCO.SendMessage("pick");
        }

        if (istouchingbush == true && Input.GetKeyDown(KeyCode.O))
        { 
            
            if (hidden == true)
            {
                Unhide();

            }

            else 
            {
                Hide();
            }

        }
        if (istouchingbank == true && Input.GetKeyDown(KeyCode.O))
        {

            if (hidden == true)
            {
                Unhide();

            }

            else
            {
                Hide();
            }
        }
    }

    void Hide()
    {
        cCO.SendMessage("hidden", true);
        hidden = true;
		spriteRenderer.enabled = false;
		anim.enabled = false;
    }
    void Unhide()
    {
        cCO.SendMessage("hidden", false);
        hidden = false;
		spriteRenderer.enabled = true;
		anim.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bush")
        {
            istouchingbush = true;
            cCO = other.gameObject;

        }
        if(other.tag == "Bank")
        {
            istouchingbank = true;
            cCO = other.gameObject;
        }
        if (other.tag == "Food")
        {
            istouchingFood = true;
            cCO = other.gameObject;
        }
    }

    void OnTriggerExit()
    {
        istouchingbush = false;
        istouchingbank = false;
        istouchingFood = false;
        cCO = null;
    }

    void resourcecollect(int amount)
    {
        Debug.Log("picked");
        resources += amount;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        gather();

    }

    void gather()
    {
        anim.SetBool("gathering", false);
        gathering = false;
        cCO.SendMessage("pick");
    }
 
}
