# 用jQuery Mobile建立跨平台行動網頁 
### 使用套件
* 2.2.4版本jQuery與jQuery.mobile做出檢視畫面
* EntityFramework 建立資料庫


### 分頁說明
#### Index
點選連結到各個頁面，包含關於我們、椅子款式、連絡方式、分店資訊。<p>
![](https://hackmd.io/_uploads/rk6kJJvAn.png)

#### About
![](https://hackmd.io/_uploads/HkWZkkwCn.png)

#### ChairsList
搭配資料庫做出檢視<p>
![](https://hackmd.io/_uploads/SyQ8y1PAn.png)<p>
資料庫<p>
![](https://hackmd.io/_uploads/rJxLX1DCh.png)<p>
頁面程式碼
```
@model IEnumerable<MvcJqueryMobile.Models.Chair>
@{
    ViewBag.Title = "ChairsList";
    var Category = "";
}
<div data-role="header" data-add-back-btn="true">
    <a href="#" data-role="button" data-rel="back" data-theme="b">返回</a>
    <h1>各類型椅子及價格參考</h1>
</div>

<div data-role="content">
    <ul data-role="listview" data-inset="true"  data-theme="a" data-divider-theme="b">
        @foreach (var chair in Model)
        {
            //替每個椅子建立List Divider
            if (Category != chair.Category)
            {
                Category = chair.Category;
                <li data-role="list-divider"><h1>@chair.Category</h1></li>
            }
            //顯示每筆資料
            <li data-icon="false">
                <a href=@chair.Url>
                    <img src="~/Assets/images/chairs/@chair.ImageUrl" />
                    <h2>@chair.Name</h2>
                    <p>價格:NT$@chair.Price</p>
                </a>
            </li>
        }
    </ul>
</div>
```

#### Contact
點選即可可以撥號、發Email等等<p>
![](https://hackmd.io/_uploads/SkwI1JvAh.png)<p>

#### Stores
於頁面顯示Table<p>
![](https://hackmd.io/_uploads/HynIyJPRn.png)

