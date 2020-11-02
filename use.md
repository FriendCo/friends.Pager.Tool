# friends.Pager.Tool

Question : How Use This Tool?
Answer : 
for Use this Tool => first Refrence pager.csproj to your project 
and go to your class or controller for use this 

and use like this code 

        public async Task<IActionResult> Index(int id = 0)
        {
            var lst = (List<T>) await _project.GetAll();
            var result = Pager<T>.Paging(T,10, id);

            ViewBag.page = id + 1;
            ViewBag.pageCount = result.PageCount;

            return View(result.List);
        }

this code return a result that has Page Count and List<T> (Your List Type)

now Go to View For Use Paging 

in line one or any line write this code 
<p>Page Id = @ViewBag.page</p>

and Get The End and Insert This Code 

<div class="parentPaging">

    @for (int i = 0; i < ViewBag.pageCount; i++)
    {
        int count = i + 1;
        <a asp-action="Index" asp-route-id="@i" class="pager">@count</a>
    }
</div>

Finished 
Thanks For Use this Tool
