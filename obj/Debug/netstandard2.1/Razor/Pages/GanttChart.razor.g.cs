#pragma checksum "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\Pages\GanttChart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79b692011d71416f641314c05299b3ddc6cc52c1"
// <auto-generated/>
#pragma warning disable 1591
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
            __Blazor.WebApplication1.Pages.GanttChart.TypeInference.CreateSfGantt_0(__builder, 0, 1, 
#nullable restore
#line 4 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\Pages\GanttChart.razor"
                      TaskCollection

#line default
#line hidden
#nullable disable
            , 2, "450px", 3, "1000px", 4, 
#nullable restore
#line 4 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\Pages\GanttChart.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
            , 5, (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Gantt.GanttTaskFields>(7);
                __builder2.AddAttribute(8, "Id", "TaskId");
                __builder2.AddAttribute(9, "Name", "TaskName");
                __builder2.AddAttribute(10, "StartDate", "StartDate");
                __builder2.AddAttribute(11, "EndDate", "EndDate");
                __builder2.AddAttribute(12, "Duration", "Duration");
                __builder2.AddAttribute(13, "Progress", "Progress");
                __builder2.AddAttribute(14, "Child", "SubTasks");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Gantt.GanttTimelineSettings>(16);
                __builder2.AddAttribute(17, "TimelineViewMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Gantt.TimelineViewMode>(
#nullable restore
#line 8 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\Pages\GanttChart.razor"
                                             TimelineViewMode.Month

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "TimelineUnitSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\Pages\GanttChart.razor"
                                                                                       200

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Gantt.GanttEditSettings>(20);
                __builder2.AddAttribute(21, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\Pages\GanttChart.razor"
                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Gantt.EditMode>(
#nullable restore
#line 9 "E:\Temp\BlazorDemo\WebApplication1\WebApplication1\Pages\GanttChart.razor"
                                                 Syncfusion.Blazor.Gantt.EditMode.Dialog

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n");
            }
            );
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
namespace __Blazor.WebApplication1.Pages.GanttChart
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGantt_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Gantt.SfGantt<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "Height", __arg1);
        __builder.AddAttribute(__seq2, "Width", __arg2);
        __builder.AddAttribute(__seq3, "AllowFiltering", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
