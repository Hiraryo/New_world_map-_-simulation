using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_ground : MonoBehaviour
{
    // Start is called before the first frame update
    public float right = 5f;
    public float length = 10f;
    private GameObject obj;
    void Start()
    {
        //ResourcesフォルダからCubeプレハブのオブジェクトを取得
        obj = (GameObject) Resources.Load("Ground 5");
        Spawn();//スポーン関数へ
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()//地面生成
    {
        for (float j = 0; j < 3.6f*right;)//１つ(4x3ブロック = 0.36x0.27)のタイルをX軸方向へright個並べる、１ブロック：0.09x0.09
        {
            j += 3.6f;//次の列に移動する為に3.6 X軸方向へ移動する
            for (float i = 0; i < length; i++)    //Z軸方向へlength個並べる
            {
                //プレハブを元にオブジェクトを生成する
                Instantiate(obj, new Vector3(i*-3.6f+j,0.0f,i*2.7f) , transform.rotation);
            }
        }
        
    }
}
