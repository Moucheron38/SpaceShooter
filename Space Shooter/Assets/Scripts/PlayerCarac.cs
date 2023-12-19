using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerCarac : MonoBehaviour
{

    public AudioMixerSnapshot GameOver;

    [SerializeField]
    private Material flashmaterial;

    [SerializeField]
    private float duration;

    private SpriteRenderer spriteRenderer;

    private Material originalMaterial;

    private Coroutine flashRoutine;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalMaterial = spriteRenderer.material;
    }

    private IEnumerator FlashRoutine()
    {
        spriteRenderer.material = flashmaterial;
        yield return new WaitForSeconds(duration);
        spriteRenderer.material = originalMaterial;
        flashRoutine = null;
    }


    public void TakeDamage(int _damage)
    {
        GameManager.LIFE -= _damage;

        if (GameManager.LIFE <= 0)
            GetComponent<PlayerControler>().enabled = false;
        if (GameManager.LIFE <= 0)
            GameManager.launchGameOver();
        if (GameManager.LIFE <= 0)
            GameOver.TransitionTo(0.01f);



    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Enemy"))
        {
            
            TakeDamage(1);
            Flash();


        }

       
        

    }
    public void Flash()
    {
        if (flashRoutine != null)
        {
            StopCoroutine(flashRoutine);
        }
        flashRoutine = StartCoroutine(FlashRoutine());
    }



}

