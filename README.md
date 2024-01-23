# personal project

# 개발 기간
- 2024년 1월 18일 ~ 2024년 1월 23일


# 개발 환경
- Unity v.2022.3.2.f1
- c#
- .NET 8.0


# 주요 기능
- 필수 기능
	* 게임 시작화면
	* 캐릭터 선택
	* 캐릭터 이름 입력 : 2초과 10미만 글자 조건
	* 캐릭터 이동
	* 방 만들기
	* 카메라 따라가기
	* 캐릭터 애니메이션
	* 캐릭터 이름 tag (캐릭터 위에 이름 표시가 따라다님)
- 선택 기능
	* 인게임 캐릭터 선택

	

# 구성(gameObject and Cs)

- <시작화면> : StartScene
	* Background : 백그라운드 이미지
	* Characters : 캐릭터
	* ChooseCharacterTextUI : 캐릭터 선택 창
	* InputNameUI : 이름 입력 창
  
	* CharacterSelect.cs : 캐릭터 선택 시 연동 파일
	* NameInput.cs : 이름 입력과 버튼 클릭 연동 파일

	
- <메인화면> : MainScene
	* Main Camera
	* Grid : tile로 배경 작업
	* Player : 캐릭터 & 캐릭터 이름 표시
	* GameManager : 캐릭터 선택에 따른 변화 제어
	* Canvas : UI bar, Character 변경 버튼 & UI창

	Folder(파일 설명)
	* Animation
		Monster 캐릭터 애니메이션 & animator
		용사 캐릭터 애니메이션 & animator
	* Input
		Input system을 활용한 WASD 이동 키, 마우스 포인트 기능
	* OutSource
		외부에서 받아온 image 파일
	* Prefabs(not completed)
		별도로 object가 보이지는 않지만 공격 범위를 제공하기 위해 prefab 설정
	* Resources
		외부에서 받아온 image 파일
	* Script
		CharacterChangeBtn : 메인화면 캐릭터 변경 버튼
		CharacterChnageResult : 메인화면 캐릭터 변경 -> 캐릭터 선택 -> 버튼 작동
		GameManager : 캐릭터 변경 기능 제어
		PlayerInputController : 사용자가 input action 키를 누를시 작동 & 카메라가 따라다니도록 update마다 위치값 제공
		XY_AnimationController : animator 설정 제어
		XY_CharacterController : Input action에서 제공하는 함수 호출 관리
		
		XY_Animation : XY_AnimationController의 부모클래스로 animator 연결점 설정
		XY_Attack : (not completed)
		XY_CharacterName : 캐릭터 이름 연동(StartScene -> MainScene)
		XY_Movement : WASD 입력에 따른 이동 거리 계산
		
		