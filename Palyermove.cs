using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Palyermove : MonoBehaviour
{
    public GameObject sd;
    public CharacterController characterController;
    public Transform tt;
    bool f, ISJUMP;
    Vector3 flipScale = new Vector3(-1, 1, 1); //翻转后的轴的值为负
    Animator animator;
    Rigidbody2D rb;
    public float POWER;
    bool firstjump;//一次跳跃判断值

    // Start is called before the first frame update
    void Start()
    {
        ISJUMP = true;

        Vector3 vvv = new Vector3(0, 180, 0);
        animator = GetComponent<Animator>();
        animator.SetBool("isRun", false);
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("isjump", false);
    }

    // Update is called once per frame
    void Update()
    {

       
        Direction();

        MOve();
       

    }

    private void MOve()
    {

        Vector3 xx = transform.position;
        if (xx != Vector3.zero)
        {
            if (Input.GetKey(KeyCode.A) ^ Input.GetKey(KeyCode.D))
            { animator.SetBool("isRun", true); }
            else { animator.SetBool("isRun", false); }

            float a = Input.GetAxis("Horizontal");
           


            Vector2 z = new Vector2(2 * a * Time.deltaTime, 0);

            sd.transform.Translate(z);
            Tiao();
       



        }
        


    }
    private void FixedUpdate()
    {
     

    }
    public void Direction()
    {
        float turnX = Input.GetAxis("Horizontal");
        if (turnX < 0)
            transform.localScale = flipScale;
        else if (turnX > 0)
            transform.localScale = Vector3.one; //Vector3.one即Vector3(1,1,1)
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
       ISJUMP=true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {ISJUMP=false;
        Debug.Log(88);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      ISJUMP=true;
        
    }
    private void Tiao()
    {
        if (ISJUMP == true)
        {
            Debug.Log(55);
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log(666);
                rb.AddForce(new Vector2(0, 5) * POWER * Time.deltaTime, ForceMode2D.Impulse);
                animator.SetTrigger("ll");
            }
        }
    }


}
