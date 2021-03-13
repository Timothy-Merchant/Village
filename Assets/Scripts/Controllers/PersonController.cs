using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;
    public bool isActive;
    public UIHandler uIHandler;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;

        Grid grid = transform.parent.GetComponent<Grid>();
        Vector3Int cellPosition = grid.WorldToCell(transform.position);
        transform.position = grid.GetCellCenterWorld(cellPosition);

        uIHandler = FindObjectOfType<UIHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (isActive)
        {
            if (Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
            {
                if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
                {
                   uIHandler.turns -= 1;
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
                if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
                {
                   uIHandler.turns -= 1;
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }

    }
}
