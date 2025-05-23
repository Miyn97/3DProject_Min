# 3DProject_Min

## 개인과제 설명
![image](https://github.com/user-attachments/assets/bc61bfad-8ffa-45e4-9e0e-0c88df12364a)



### Unity3D의 캐릭터 이동과 물리 처리를 직접 구현하는 과제를 만들었습니다.

## 필수 기능 완료
1. 기본 이동 및 점프 Input System, Rigidbody ForceMode
2. 체력바 UI 
3. 동적 환경 조사 Raycast UI (아이템을 향해 Ray)
4. 점프대 (JumpZone 큐브 3D 오브젝트)
5. 아이템 데이터 (ScriptableObject)
6. 아이템 사용 (Coroutine) - Item_Cookie

## 도전 기능 
1. 추가 UI : 배고픔 게이지 UI + 스테미나 UI 를 기존 강의내용을 토대로 구성하였습니다.
2. 3인칭 시점 : 단축키 V를 통해 1인칭과 3인칭을 번갈아 전환할 수 있도록 구성하였습니다.
3. 움직이는 플랫폼 구현 : 코루틴을 사용해 3초의 대기시간을 가지고 일정한 속도로 번갈아 움직이는 무빙플랫폼을 구성하였습니다.
4. 사운드 구현 : 발자국 소리와 MusicZone을 통해 일정 장소에 진입하면 소리가 들리도록했고, Fade In과 Fade Out기능을 구성하였습니다.


## 스스로 해보는 도전 기능 
![image](https://github.com/user-attachments/assets/12e51fd7-369e-4c34-91ed-33ffd223d161)
1. 무료 에셋을 다운받아서 Terrain을 이용해 던전 들어가기 전 재정비 느낌의 맵(협곡)을 디자인했습니다.
2. 나무에 어떤부분을 도끼로 공격을해야 나무를 얻을 수 있는지 표적과 파티클 효과를 추가했습니다.
3. 점프대를 바라볼 때 점프대에 관련된 설명과 파티클 효과를 추가했습니다. (Ray)
4. 스테미나가 감소하는것을 구현했습니다.

   



## 트러블슈팅
[https://velog.io/@tn9797/Null-Reference-Exception-오류-해결](https://velog.io/@tn9797/Null-Reference-Exception-오류-해결-z47dq68o)
