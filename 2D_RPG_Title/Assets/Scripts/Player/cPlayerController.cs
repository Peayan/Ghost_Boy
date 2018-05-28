using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cPlayerController : MonoBehaviour {

    public float m_fPlayerSpeed = 10;
    public Animator m_Anim;
    public Rigidbody2D m_rbPlayer;

    float m_fHorizontalMovement;
    float m_fVerticalMovement;
    bool m_bPlayingMoving;

    Vector2 m_PlayerDirection;

	// Use this for initialization
	void Awake ()
    {
        cMain.mPlayerController = this;
	}

    private void Start()
    {
        m_rbPlayer = GetComponent<Rigidbody2D>();
        m_Anim = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update()
    {
        m_fHorizontalMovement = Input.GetAxisRaw("Horizontal");
        m_fVerticalMovement   = Input.GetAxisRaw("Vertical");

        m_bPlayingMoving = false;
        m_rbPlayer.velocity = Vector2.zero;


        if (m_fHorizontalMovement < -0.5 || m_fHorizontalMovement > 0.5f)
        {
            m_bPlayingMoving = true;
            m_rbPlayer.velocity = new Vector2(m_fHorizontalMovement * m_fPlayerSpeed * Time.deltaTime, m_rbPlayer.velocity.y);
            m_PlayerDirection = new Vector2(m_fHorizontalMovement, 0);
        }

        if (m_fVerticalMovement < -0.5 || m_fVerticalMovement > 0.5f)
        {
            m_bPlayingMoving = true;
            m_rbPlayer.velocity = new Vector2(m_rbPlayer.velocity.x, m_fVerticalMovement * m_fPlayerSpeed * Time.deltaTime);
            m_PlayerDirection = new Vector2(0, m_fVerticalMovement);
        }
        
        m_Anim.SetFloat("LastDirectionX", m_PlayerDirection.x);
        m_Anim.SetFloat("LastDirectionY", m_PlayerDirection.y);
        m_Anim.SetBool("PlayerMoving", m_bPlayingMoving);
        m_Anim.SetFloat("HorizontalMovement", m_fHorizontalMovement);
        m_Anim.SetFloat("VerticalMovement", m_fVerticalMovement);

        //if (Input.anyKeyDown) {   }
        //else m_Anim.SetBool("PlayerIdle", true);
    }
}
