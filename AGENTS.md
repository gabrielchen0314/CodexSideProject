## C# Coding Style

### 1. 命名規則
- 成員變數：加上前綴 m_  
  例：public int m_Count_Grid;
- 靜態/常數變數：使用大寫，可選擇性加上 s_  
  例：private const string SYMBOL_AUTO_REF = "&";
  例：public static ushort s_Idx_IC = 83;
- 參數：加上前綴 i  
  例：public void Search(Transform iTrans)
- 區域變數：加上前綴 _  
  例：int _Random = Random.Range(0, m_List_GetAward.Count);
- 列舉：加上前綴 E  
  例：private enum ETypeOfTurn { Simple = 0, Actually, Surprise, Max }
- 布林變數：使用 Is、Can、Have、Has  
  例：public bool m_CanRun;  
  例：bool _HaveItem;
- 集合：  
  例：List m_List_Name;  
  例：Dictionary<TKey, TValue> m_Dic_Name;

### 2. 註解
- 使用內建的 /// 格式進行文件註解
- 類別中需包含目的、版本和作者資訊
- 修改時需註明作者和日期
- 註解放置於程式碼實作前

### 3. 程式碼結構
- 避免使用 var 關鍵字（不易識別型別）
- 所有變數宣告都必須指定型別
- 迴圈最多不超過三層
- switch 陳述句必須包含 default 情況
- 不使用魔術數字 - 使用常數或列舉
- 成員變數需使用適當的保護層級

### 4. 格式規範
- 使用 Tab（4個空格）進行縮排
- 大括號必須對齊
- 陳述句和函式之間需要空一行
- 每個變數需分開宣告

---

## Lua Coding Style

### 1. 命名規則
- 成員變數：加上前綴 m_ 並標示型別  
  例：local m_Text_Level = nil;  -- Unity Text  
  例：local m_Trans_Root = nil;  -- Unity Transform  
  例：local m_Obj_Root = nil;    -- Unity GameObject
- 參數：加上前綴 i  
  例：function Demo(iStr_Level)
- 區域變數：加上前綴 _  
  例：local _GObj = nil;

### 2. 註解
- 使用 --- 作為可懸停提示的註解
- 使用 ---@param 和 ---@return 進行函式文件註解
- 使用 --region 和 --endregion 區分程式碼區段
- 其他情況遵循 C# 註解風格

### 3. 重要注意事項
- 嚴禁創建名為 self 的變數
- 陣列索引從 1 開始（語言限制）
- 避免使用底線加大寫字母的組合（保留給 Lua 內部使用）

### 4. 程式碼結構
- Unity 物件需加上型別標示
- 迴圈最多不超過三層
- 需詳細記錄參數和回傳值
- 盡可能遵循 C# 的一般程式碼原則

---

### 5. 制式版權註解
（此區段為固定格式，無需更動）