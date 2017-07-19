using UnityEngine;
using System.Collections;

public class Enemygenerator : MonoBehaviour {
    public GameObject Enemy_RedPrefab;
    public GameObject Enemy_BluePrefab;
    public GameObject Enemy_GreenPrefab;
    public GameObject Enemy_YellowPrefab;
    public GameObject Enemy_AnyPrefab;
    public GameObject Enemy_AllPrefab;

    float span = 1.0f;
    float delta = 0;

    float[] EnemyPos = new float[4] {-1.5f, -0.5f, 0.5f, 1.5f};

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;

        //1秒ごとに敵を出します
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject Enemy = null;
            int dice = Random.Range(0, 6);
            switch (dice)
            {
                case 0:
                    Enemy = Instantiate(Enemy_AnyPrefab) as GameObject;
                    break;

                case 1:
                    Enemy = Instantiate(Enemy_RedPrefab) as GameObject;
                    break;

                case 2:
                    Enemy = Instantiate(Enemy_BluePrefab) as GameObject;
                    break;

                case 3:
                    Enemy = Instantiate(Enemy_GreenPrefab) as GameObject;
                    break;

                case 4:
                    Enemy = Instantiate(Enemy_YellowPrefab) as GameObject;
                    break;

                case 5:
                    for (int i = 0; i < 4; i++)
                    {
                        Enemy = Instantiate(Enemy_AllPrefab) as GameObject;
                        Enemy.transform.position = new Vector3(EnemyPos[i], 0.5f, 0.0f);
                    }
                    break;
            }
            if (dice != 5)
            {
                int x = Random.Range(0, 4);
                Enemy.transform.position = new Vector3(EnemyPos[x], 0.5f, 0.0f);
            }
        }
	}
}
