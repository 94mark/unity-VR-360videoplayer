using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; //VideoPlayer 기능을 사용하기 위한 네임스페이스

public class VideoFrame : MonoBehaviour
{
    //Video Player 컴포넌트
    VideoPlayer vp;
    
    void Start()
    {
        //현재 오브젝트의 비디오 플레이어 컴포넌트 정보를 가지고 온다
        vp = GetComponent<VideoPlayer>();
        //자동 재생되는 것을 막는다
        vp.Stop();
    }

    void Update()
    {
        //S를 누르면 정지
        if(Input.GetKeyDown(KeyCode.S))
        {
            vp.Stop();
        }
        //스페이스 바를 눌렀을 때 재생 또는 일시 정지
        if(Input.GetKeyDown("space"))
        {
            //현재 비디오 플레이어가 플레이 상태인지 확인
            if(vp.isPlaying)
            {
                //재생 중이라면 일시 정지
                vp.Pause();
            }
            else
            {
                //그렇지 않다면 플레이
                vp.Play();
            }
        }
    }

    //GazePointerCtril에서 영상 재생을 컨트롤하기 위한 함수
    public void CheckVideoFrame(bool Checker)
    {
        if(Checker)
        {
            if(!vp.isPlaying)
            {
                vp.Play();
            }
        }
        else
        {
            vp.Stop();
        }
    }
    public void OnEnable()
    {
        if(vp != null)
        {
            vp.Stop();
        }
    }
}
