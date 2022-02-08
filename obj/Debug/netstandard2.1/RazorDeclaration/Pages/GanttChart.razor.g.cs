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
#line 2 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\Pages\GanttChart.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GanttChart")]
    public partial class GanttChart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\Pages\GanttChart.razor"
       

    public List<TaskData> TaskCollection { get; set; }

    public static List<TaskData> GetTaskCollection()
    {
        List<TaskData> Tasks = new List<TaskData>() {
        new TaskData() {
            TaskId = 1,
            TaskName = "Project initiation",
            StartDate = new DateTime(2020, 06, 09),
            EndDate = new DateTime(2020, 06, 26),
            SubTasks = (new List <TaskData> () {
                new TaskData() {
                    TaskId = 2,
                    TaskName = "Identify Site location",
                    StartDate = new DateTime(2020, 06, 09),
                    Duration = "4",
                    Progress = 50,
                },
                new TaskData() {
                    TaskId = 3,
                    TaskName = "Perform soil test",
                    StartDate = new DateTime(2020, 06, 09),
                    Duration = "4",
                    Progress = 50,
                }
            })
        }
    };
        return Tasks;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        this.TaskCollection = GetTaskCollection();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591