# personal project

# ���� �Ⱓ
- 2024�� 1�� 18�� ~ 2024�� 1�� 23��


# ���� ȯ��
- Unity v.2022.3.2.f1
- c#
- .NET 8.0


# �ֿ� ���
- �ʼ� ���
	* ���� ����ȭ��
	* ĳ���� ����
	* ĳ���� �̸� �Է� : 2�ʰ� 10�̸� ���� ����
	* ĳ���� �̵�
	* �� �����
	* ī�޶� ���󰡱�
	* ĳ���� �ִϸ��̼�
	* ĳ���� �̸� tag (ĳ���� ���� �̸� ǥ�ð� ����ٴ�)
- ���� ���
	* �ΰ��� ĳ���� ����

	

# ����(gameObject and Cs)

- <����ȭ��> : StartScene
	* Background : ��׶��� �̹���
	* Characters : ĳ����
	* ChooseCharacterTextUI : ĳ���� ���� â
	* InputNameUI : �̸� �Է� â
  
	* CharacterSelect.cs : ĳ���� ���� �� ���� ����
	* NameInput.cs : �̸� �Է°� ��ư Ŭ�� ���� ����

	
- <����ȭ��> : MainScene
	* Main Camera
	* Grid : tile�� ��� �۾�
	* Player : ĳ���� & ĳ���� �̸� ǥ��
	* GameManager : ĳ���� ���ÿ� ���� ��ȭ ����
	* Canvas : UI bar, Character ���� ��ư & UIâ

	Folder(���� ����)
	* Animation
		Monster ĳ���� �ִϸ��̼� & animator
		��� ĳ���� �ִϸ��̼� & animator
	* Input
		Input system�� Ȱ���� WASD �̵� Ű, ���콺 ����Ʈ ���
	* OutSource
		�ܺο��� �޾ƿ� image ����
	* Prefabs(not completed)
		������ object�� �������� ������ ���� ������ �����ϱ� ���� prefab ����
	* Resources
		�ܺο��� �޾ƿ� image ����
	* Script
		CharacterChangeBtn : ����ȭ�� ĳ���� ���� ��ư
		CharacterChnageResult : ����ȭ�� ĳ���� ���� -> ĳ���� ���� -> ��ư �۵�
		GameManager : ĳ���� ���� ��� ����
		PlayerInputController : ����ڰ� input action Ű�� ������ �۵� & ī�޶� ����ٴϵ��� update���� ��ġ�� ����
		XY_AnimationController : animator ���� ����
		XY_CharacterController : Input action���� �����ϴ� �Լ� ȣ�� ����
		
		XY_Animation : XY_AnimationController�� �θ�Ŭ������ animator ������ ����
		XY_Attack : (not completed)
		XY_CharacterName : ĳ���� �̸� ����(StartScene -> MainScene)
		XY_Movement : WASD �Է¿� ���� �̵� �Ÿ� ���
		
		