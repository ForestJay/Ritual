using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{
    public float distanceToGround;
    RaycastHit hit;
    Animator anim;
    private SpriteRenderer spriteRenderer;
    // Use this for initialization

    public Sprite up;
    public Sprite down;
    public Sprite left;
    public Sprite right;
    bool faceright = false;
    public bool faceleft = false;
    bool faceup = false;
    bool facedown = false;
	public bool currentlymoving = false;
	public bool flipped = true;

    void Start()
    {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //	if (Physics.Raycast (transform.position, -Vector3.up, out hit)) {
        //		distanceToGround = hit.distance - transform.GetComponent<Collider> ().bounds.extents;
        //		transform.position.y = distanceToGround;
        if (this.gameObject.GetComponent<Interact>().hidden == false && this.gameObject.GetComponent<Interact>().gathering == false)
        {

			if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
				currentlymoving = true;
				spriteRenderer.flipX = true;
                transform.Translate(-3f * Time.deltaTime, 0, 0);
                anim.SetBool("movingleft", false);
                anim.SetBool("movingright", true);
                anim.SetBool("movingdown", false);
                anim.SetBool("movingup", false);
				anim.SetBool("facedown", false);
				anim.SetBool("faceup", false);
				anim.SetBool("faceleft", false);
				anim.SetBool("faceright", false);

            }
			else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
				currentlymoving = true;
				spriteRenderer.flipX = false;
                transform.Translate(3f * Time.deltaTime, 0, 0);
                anim.SetBool("movingright", true);
                anim.SetBool("movingleft", false);
                anim.SetBool("movingdown", false);
                anim.SetBool("movingup", false);
				anim.SetBool("facedown", false);
				anim.SetBool("faceup", false);
				anim.SetBool("faceleft", false);
				anim.SetBool("faceright", false);
            }
			else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
				
                transform.Translate(0, 0, 3f * Time.deltaTime);
				anim.SetBool("movingdown", false);
				anim.SetBool("movingleft", false);
				anim.SetBool("movingright", false);
				anim.SetBool("movingup", true);
				anim.SetBool("faceup", false);
				anim.SetBool("faceleft", false);
				anim.SetBool("faceright", false);
				anim.SetBool("facedown", false);
            }
			else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, 0, -3f * Time.deltaTime);

                anim.SetBool("movingdown", true);
                anim.SetBool("movingleft", false);
                anim.SetBool("movingright", false);
                anim.SetBool("movingup", false);
                anim.SetBool("faceup", false);
                anim.SetBool("faceleft", false);
                anim.SetBool("faceright", false);
                anim.SetBool("facedown", false);

			}
			else if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
			{
				
				spriteRenderer.flipX = false;
					anim.SetBool ("movingdown", false);
					anim.SetBool ("movingleft", false);
					anim.SetBool ("movingright", false);
					anim.SetBool ("movingup", false);
					anim.SetBool ("faceup", false);
					anim.SetBool ("faceleft", false);
					anim.SetBool ("faceright", false);
					anim.SetBool ("facedown", true);


            }
			else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
            {
				
					spriteRenderer.flipX = true;
					anim.SetBool ("movingdown", false);
					anim.SetBool ("movingleft", false);
					anim.SetBool ("movingright", false);
					anim.SetBool ("movingup", false);
					anim.SetBool ("faceup", false);
					anim.SetBool ("faceleft", false);
					anim.SetBool ("faceright", true);
					anim.SetBool ("facedown", false);
			}
			else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
            {
				
					spriteRenderer.flipX = false;
					anim.SetBool ("movingdown", false);
					anim.SetBool ("movingleft", false);
					anim.SetBool ("movingright", false);
					anim.SetBool ("movingup", false);
					anim.SetBool ("faceup", false);
					anim.SetBool ("faceleft", false);
					anim.SetBool ("faceright", true);
					anim.SetBool ("facedown", false);


            }
			else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow)){
				
					spriteRenderer.flipX = false;
					anim.SetBool ("movingdown", false);
					anim.SetBool ("movingleft", false);
					anim.SetBool ("movingright", false);
					anim.SetBool ("movingup", false);
					anim.SetBool ("faceup", true);
					anim.SetBool ("faceleft", false);
					anim.SetBool ("faceright", false);
					anim.SetBool ("facedown", false);

				
                }
            }

    	}
    }

    

