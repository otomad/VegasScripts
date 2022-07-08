![VegasScripts](https://github.com/otomad/VegasScripts/blob/winform/banner.png?raw=true)
<h2 align="center">音 MAD 助手</h2>
<div align="center">
	<p><a href="https://github.com/otomad/VegasScripts/releases/latest">點擊下載最新版！</a></p>
	<p>
		<a href="README.md">EN</a> |
		<a href="README_zh-CN.md">簡中</a> |
		<strong>繁中</strong> |
		<a href="README_ja-JP.md">日</a>
	</p>
</div>

音 MAD 助手 Vegas 版，旨在使 Vegas 接受 MIDI 序列檔案作為輸入，自動生成音 MAD / YTPMV 的軌道。

本腳本基於原作者 [@Chaosinism](https://github.com/Chaosinism) 的開原始程式碼二次開發，此外使用了 NAudio 庫。

也可以製作 YTP。未來也可用於製作鼓組節奏區域切除、歌詞/卡拉OK、人力/Rap、韃靼戰法。

未來也會增加商城功能用於下載其他使用者製作的範本等相關素材。

### 使用方法
在軌道視窗中選中素材，或在專案媒體視窗中選中素材，或在（打開腳本視窗後）手動流覽選擇其它素材。然後即可打開腳本配置並生成。

您可以選擇菜單 *選項 > 自訂工具列*，將腳本添加到工具列中以便操作。

您也可以閱讀 [@Evauation](https://github.com/Evauation) 的[文檔](https://docs.google.com/document/d/1PEkh0_WFDLUAYGD-YzIDNXUQiAKqogEvpuRQhfqz9ng/edit)並觀看他的[教程視頻](https://www.youtube.com/watch?v=8vSpzgL_86A)*（英語）*。

### 安裝
1. [下載](https://github.com/otomad/VegasScripts/releases/latest)最新版腳本。
2. 解壓**所有**壓縮包內的檔案並放置到 Vegas 安裝目錄下的“Script Menu”資料夾中。
> (例如：C:\Program Files\VEGAS\VEGAS Pro 17.0\Script Menu)
3. 確保 DLL 檔案 (DLL/NAudio.dll) 沒有被鎖定。**具體步驟：**
	1. 在 Vegas 安裝目錄下， 依次進入資料夾 Script Menu/DLL。
	2. 右鍵 NAudio.dll 檔案，並選擇“屬性”。
	3. 如果您看到了“解除鎖定”按鈕，就點一下。
	4. 關閉屬性對話框即可。
4. 打開您的 Vegas Pro 來啟動腳本。選擇菜單 *工具 > 腳本化 > Otomad Helper*。

### **注意**
支援 Vegas Pro 13 及以上版本。

Vegas 16 及以上版本支援所有功能，Vegas 13 ~ 15 可以兼容運行（會缺失部分功能）。前提是必須安裝對應的版本。

Vegas Pro 17 和 19 測試**正常**。

### 問題
使用腳本時，如果您：
1. 遇到了麻煩；
2. 發現了錯誤；
3. 有新的建議或想法；
4. 幫助維護項目；
5. 優化介面外觀；
6. 修正翻譯問題；
7. 提交新的翻譯；
8. ……

都可以提出 issues。

### 路線圖
[路線圖 >](ROADMAP.md)

### 許可權
使用腳本時，將會使用如下許可權：
1. 文件讀寫。<br />
	腳本會在磁碟中創建一個檔案用來保存您的使用者配置設置。
2. 註冊表讀寫。<br />
	腳本需要讀寫註冊表來安裝或卸載移調外掛插件預設。<br />
	如果您不使用移調插件這個調音算法，您可以忽略該許可權。

### 參考
* [https://github.com/Chaosinism/vegas_scripts](https://github.com/Chaosinism/vegas_scripts)
* [https://github.com/evankale/VegasScripts](https://github.com/evankale/VegasScripts)
* [https://github.com/naudio/NAudio](https://github.com/naudio/NAudio)
* [https://www.jetdv.com/](https://www.jetdv.com/)
* [https://www.vegascreativesoftware.info/us/vegas-pro-forum/scripting/](https://www.vegascreativesoftware.info/us/vegas-pro-forum/scripting/)

### 圖示
靈感來源於:
* [@uid13084550](https://space.bilibili.com/13084550)
* [@uid8569439](https://space.bilibili.com/8569439)

### 幫助和疑難排解 *（中文）*
**我的文件：**
* [說明文檔 (v4.9.25.0)](https://www.bilibili.com/read/cv13335178)
* [說明文檔 (v4.10.17.0)](https://www.bilibili.com/read/cv13614419)

**Chaosinism 的原版文檔：**
* [說明文檔 (v0.1) (B 站)](https://www.bilibili.com/read/cv392013)
* [說明文檔 (v0.1) (B 碗)](https://bowlroll.net/user/261124)
* [五線譜視覺化文檔 (v0.1)](https://www.bilibili.com/read/cv1027442)
* [疑難排解](https://www.bilibili.com/read/cv495309)
* [教程視頻 (v0.1)](https://www.bilibili.com/video/av22226321)