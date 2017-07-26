using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public enum Color
    {
        Red,
        Blue,
        Green,
        Yellow,
        Any,
        All
    }

    public Color color = new Color();

	// Use this for initialization
    public float moveSpeed;
	void Start () {
        moveSpeed = -0.05f;
        switch(transform.tag)
        {
            case "Enemy_Red":
                //どの色か控えをとる
                color = Color.Red;
                break;

            case "Enemy_Blue":
                //どの色か控えをとる
                color = Color.Blue;
                break;

            case "Enemy_Green":
                //どの色か控えをとる
                color = Color.Green;
                break;

            case "Enemy_Yellow":
                //どの色か控えをとる
                color = Color.Yellow;
                break;

            case "Enemy_Any":
                //どの色か控えをとる
                color = Color.Any;
                break;

            case "Enemy_All":
                //どの色か控えをとる
                color = Color.All;
                break;
            default:
                color = Color.All;
                break;

        }
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, this.moveSpeed);

        //一定距離に進入してきたかどうか
        if (transform.position.z < -5.0)
        {
            //ボタンが押された
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                //プレイヤーと色が対応している
                if(DestoryCheck())
                {
                    Destroy(gameObject);
                }
            }
            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                if (DestoryCheck())
                {
                    Destroy(gameObject);
                }
            }
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                if (DestoryCheck())
                {
                    Destroy(gameObject);
                }
            }
            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                if (DestoryCheck())
                {
                    Destroy(gameObject);
                }
            }
        }

        if (transform.position.z < -8.0f)
        {
            Destroy(gameObject);
        }
	}
    bool DestoryCheck()//引数でたたいたプレイヤーを渡す
    {
        if (color == Color.All)
        {
            return true;
        }
        if (color == Color.Any)
        {
            return true;
        }
        if (color == Color.Red)//&& たたいたプレイヤー==Color.Red
        {
            return true;
        }
        if (color == Color.Blue)//&& たたいたプレイヤー==Color.Blue
        {
            return true;
        }
        if (color == Color.Green)//&& たたいたプレイヤー==Color.Green
        {
            return true;
        }
        if (color == Color.Yellow)//&& たたいたプレイヤー==Color.Yellow
        {
            return true;
        }
        return false;
    }
}
