 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{

    private Main_controller playerInput;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField]
    private float playerSpeed = 2.0f;
    // [SerializeField]
    // private float jumpHeight = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;
    public Animator anim = null;


    [Header("skill1")]
    public Image imgSkill_1;
    public Image greySkill_1;
    public float cooldown = 12f;
    public float duration = 5f;
    public float speedAddAmount = 10f;
    bool isCooldown = false;
    public TMP_Text cooldownText;
    [SerializeField] ParticleSystem skill_1EffectBurst;
    [SerializeField] ParticleSystem skill_1EffectLong;

  
    void Start()
    {
        imgSkill_1.fillAmount = 1;
        greySkill_1.gameObject.SetActive(false);
        cooldownText.gameObject.SetActive(false);
    }


    private void Awake() {
        playerInput = new Main_controller();
        controller = GetComponent<CharacterController>();
    }

    private void OnEnable() {
        playerInput.Enable();
    }

    private void OnDisable() {
        playerInput.Disable();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 movementInput = playerInput.Playermain.Move.ReadValue<Vector2>();
        // Debug.Log(movementInput);
        Vector3 move = new Vector3(movementInput.x, 0f, movementInput.y);

        //set animation speed
        anim.SetFloat("speed", (Mathf.Abs(move.x)+Mathf.Abs(move.z)) * playerSpeed);

        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (playerInput.Playermain.Attack.triggered)
        {
            anim.SetTrigger("attack");

            // playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        skill_1();
    }


    void skill_1()
    {
        if(playerInput.Playermain.skill1.triggered && isCooldown is false)
        {
            isCooldown = true;
            imgSkill_1.fillAmount = 0;
            greySkill_1.gameObject.SetActive(true);
            cooldownText.gameObject.SetActive(true);
            StartCoroutine("buffSpeed");
        }

        if(isCooldown)
        {
            imgSkill_1.fillAmount += 1 / cooldown * Time.deltaTime;
            cooldownText.text = ((1 - imgSkill_1.fillAmount)*cooldown).ToString("n1");
        }

        if (imgSkill_1.fillAmount >= 1)
        {
            imgSkill_1.fillAmount = 1;
            isCooldown = false;
            greySkill_1.gameObject.SetActive(false);
            cooldownText.gameObject.SetActive(false);
        }
    }

    IEnumerator buffSpeed()
    {
        skill_1EffectBurst.Play();
        skill_1EffectLong.Play();
        playerSpeed += speedAddAmount;
        yield return new WaitForSeconds(duration);
        playerSpeed -= speedAddAmount;
        skill_1EffectLong.Stop();
    }


}
