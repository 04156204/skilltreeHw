
第一週作業題目如下<br>

>1.必須使用Layout <br>
>2.下方列表部分建議分開，不要寫死在同一頁並且要有假資料 <br>
>3.上方輸入只是切版的結果不用實現功能 <br>
>4.前方數字是流水號，不是DB的值 <br>

補充說明<br>
>作業為實作一記帳頁面。<br>
>表格呈現 流水號、類別(收入支出)、日期、金額 塞入100筆隨機資料。<br>
>金額需三位數一個逗點。<br>
>不使用LocalDB。<br>

第二週作業題目如下<br>

>1.記帳本資料改為真實DB 可使用EF ADO.NET<br>
>2.請使用HomeWorkDB內的資料 <br>
>3.不可改變第一天設計的ViewModel <br>
>4.建議練習：實做Service層 <br>
>5.額外挑戰：UnitOfWork Repository <br>

第三週作業題目如下<br>
>1.必須真的寫進資料庫<br>
>2.所有欄位必填。金額只能整數、日期不大於今天、備註100個字元。<br>
>3.列表顏色變換。支出紅色收入藍色。<br>
>進階：以Ajax傳遞資料<br>


待7/27提問<br>
>1. IEnumerableIQueryable觀念<br>
>[[Entity Framework][LINQ] IEnumerable與IQueryable差異比較](https://dotblogs.com.tw/wasichris/archive/2015/03/04/150633.aspx)<br>
>[關於IQueryable<T>特性的小實驗](https://blog.darkthread.net/blog/iqueryable-experiment/)<br>
>LINQ查詢回來我們把它ToList了，那它原本是什麼在我們沒有定義的情況下(用var之類的？？的時候)有必要手動定義它嗎？如何判斷何時IQ何時IE(是不是大部分時間推薦用IQ)<br>
>IQ 比較不浪費，那IE有優勢嗎<br>
>2. 請解說三種DropdownList<br>