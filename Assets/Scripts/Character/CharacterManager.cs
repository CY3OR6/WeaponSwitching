using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    Animator animator = null;

    [SerializeField]
    WeaponManager manager;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        manager?.attackEvent.AddListener(() => Attack());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attack()
    {
        animator.Play("New Attack Animation");
    }
}
