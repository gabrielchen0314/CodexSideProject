## C# Coding Style

### 1. �R�W�W�h
- �����ܼơG�[�W�e�� m_  
  �ҡGpublic int m_Count_Grid;
- �R�A/�`���ܼơG�ϥΤj�g�A�i��ܩʥ[�W s_  
  �ҡGprivate const string SYMBOL_AUTO_REF = "&";
  �ҡGpublic static ushort s_Idx_IC = 83;
- �ѼơG�[�W�e�� i  
  �ҡGpublic void Search(Transform iTrans)
- �ϰ��ܼơG�[�W�e�� _  
  �ҡGint _Random = Random.Range(0, m_List_GetAward.Count);
- �C�|�G�[�W�e�� E  
  �ҡGprivate enum ETypeOfTurn { Simple = 0, Actually, Surprise, Max }
- ���L�ܼơG�ϥ� Is�BCan�BHave�BHas  
  �ҡGpublic bool m_CanRun;  
  �ҡGbool _HaveItem;
- ���X�G  
  �ҡGList m_List_Name;  
  �ҡGDictionary<TKey, TValue> m_Dic_Name;

### 2. ����
- �ϥΤ��ت� /// �榡�i�������
- ���O���ݥ]�t�ت��B�����M�@�̸�T
- �ק�ɻݵ����@�̩M���
- ���ѩ�m��{���X��@�e

### 3. �{���X���c
- �קK�ϥ� var ����r�]�����ѧO���O�^
- �Ҧ��ܼƫŧi���������w���O
- �j��̦h���W�L�T�h
- switch ���z�y�����]�t default ���p
- ���ϥ��]�N�Ʀr - �ϥα`�ƩΦC�|
- �����ܼƻݨϥξA���O�@�h��

### 4. �榡�W�d
- �ϥ� Tab�]4�ӪŮ�^�i���Y��
- �j�A���������
- ���z�y�M�禡�����ݭn�Ť@��
- �C���ܼƻݤ��}�ŧi

---

## Lua Coding Style

### 1. �R�W�W�h
- �����ܼơG�[�W�e�� m_ �üХܫ��O  
  �ҡGlocal m_Text_Level = nil;  -- Unity Text  
  �ҡGlocal m_Trans_Root = nil;  -- Unity Transform  
  �ҡGlocal m_Obj_Root = nil;    -- Unity GameObject
- �ѼơG�[�W�e�� i  
  �ҡGfunction Demo(iStr_Level)
- �ϰ��ܼơG�[�W�e�� _  
  �ҡGlocal _GObj = nil;

### 2. ����
- �ϥ� --- �@���i�a�����ܪ�����
- �ϥ� ---@param �M ---@return �i��禡������
- �ϥ� --region �M --endregion �Ϥ��{���X�Ϭq
- ��L���p��` C# ���ѭ���

### 3. ���n�`�N�ƶ�
- �Y�T�ЫئW�� self ���ܼ�
- �}�C���ޱq 1 �}�l�]�y������^
- �קK�ϥΩ��u�[�j�g�r�����զX�]�O�d�� Lua �����ϥΡ^

### 4. �{���X���c
- Unity ����ݥ[�W���O�Х�
- �j��̦h���W�L�T�h
- �ݸԲӰO���ѼƩM�^�ǭ�
- �ɥi���` C# ���@��{���X��h

---

### 5. ����v����
�]���Ϭq���T�w�榡�A�L�ݧ�ʡ^