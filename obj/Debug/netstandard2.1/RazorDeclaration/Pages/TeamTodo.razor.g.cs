// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using Syncfusion.Blazor.Kanban;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\_Imports.razor"
using Syncfusion.Blazor.Gantt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\Pages\TeamTodo.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/teamToDoList")]
    public partial class TeamTodo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\Pages\TeamTodo.razor"
       
    public List<Tasks> TaskDetails = new List<Tasks>()
    {
        new Tasks { Id = "Task 1", Title = "BLAZ-29001", Status = "Open", Summary = "Analyze the new requirements gathered from the customer.", Assignee = "Nancy Davloio" },
        new Tasks { Id = "Task 2", Title = "BLAZ-29002", Status = "Open", Summary = "Show the retrieved data from the server in grid control.", Assignee = "Andrew Fuller" },
        new Tasks { Id = "Task 3", Title = "BLAZ-29003", Status = "InProgress", Summary = "Improve application performance", Assignee = "Janet Leverling" },
        new Tasks { Id = "Task 4", Title = "BLAZ-29004", Status = "Testing", Summary = "Fix the issues reported by the customer.", Assignee = "Janet Leverling" },
        new Tasks { Id = "Task 5", Title = "BLAZ-29005", Status = "Testing", Summary = "Fix the issues reported in Safari browser.", Assignee = "Steven walker" },
        new Tasks { Id = "Task 6", Title = "BLAZ-29006", Status = "Close", Summary = "Analyze SQL server 2008 connection.", Assignee = "Nancy Davloio" },
        new Tasks { Id = "Task 7", Title = "BLAZ-29007", Status = "Close", Summary = "Analyze grid control.", Assignee = "Margaret hamilt" },
        new Tasks { Id = "Task 8", Title = "BLAZ-29008", Status = "Close", Summary = "Stored procedure for initial data binding of the grid.", Assignee = "Steven walker" }
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
